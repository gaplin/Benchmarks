using BenchmarkDotNet.Attributes;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonOps;

[MemoryDiagnoser(displayGenColumns: true)]
public class Benchmarks
{
    private readonly Random _rand = new(5555);
    private string _json = "";

    [Params(100, 100_000)]
    public int Properties { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var jsonInputBuild = new StringBuilder("{");

        for (int i = Properties; i > 1; --i)
        {
            jsonInputBuild.Append($"\"property_{i}\":{_rand.Next()},");
        }
        jsonInputBuild.Append($"\"property_1\":{_rand.Next()}}}");
        _json = jsonInputBuild.ToString();
    }

    [Benchmark(Baseline = true)]
    public Target JsonSerializer_Deserlialize()
    {
        return JsonSerializer.Deserialize<Target>(_json)!;
    }

    [Benchmark]
    public Target JsonReader_Buffered()
    {
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(_json));
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.PropertyName && reader.ValueTextEquals("property_1"u8))
            {
                reader.Read();
                return new Target { Value = reader.GetInt32() };
            }
        }

        throw new InvalidOperationException("Invalid input");
    }

    [Benchmark]
    public Target JsonReader_Streamed()
    {
        Span<byte> buffer = stackalloc byte[1000];
        var jsonSpan = _json.AsSpan();
        const int chunkSize = 1000;
        var startIncl = 0;
        int endExcl = Math.Min(chunkSize, jsonSpan.Length);
        var writtenBytes = Encoding.UTF8.GetBytes(jsonSpan[startIncl..endExcl], buffer);
        startIncl += writtenBytes;
        endExcl += writtenBytes;
        int bufferEnd = writtenBytes;
        var reader = new Utf8JsonReader(buffer[..bufferEnd], isFinalBlock: false, state: default);
        while (reader.TokenType != JsonTokenType.PropertyName || !reader.ValueTextEquals("property_1"u8))
        {
            if (!reader.Read())
            {
                ReadMoreText(buffer, jsonSpan, chunkSize, ref startIncl, ref endExcl, out writtenBytes, out bufferEnd, ref reader);
            }
        }

        while (reader.TokenType != JsonTokenType.Number)
        {
            if (!reader.Read())
            {
                ReadMoreText(buffer, jsonSpan, chunkSize, ref startIncl, ref endExcl, out writtenBytes, out bufferEnd, ref reader);
            }
        }
        return new Target
        {
            Value = reader.GetInt32()
        };
        throw new InvalidOperationException("Invalid input");
    }

    private static void ReadMoreText(Span<byte> buffer, ReadOnlySpan<char> jsonSpan, int chunkSize, ref int startIncl, ref int endExcl, out int writtenBytes, out int bufferEnd, ref Utf8JsonReader reader)
    {
        int leftOverLength = 0;
        if (reader.BytesConsumed < buffer.Length)
        {
            ReadOnlySpan<byte> leftover = buffer[(int)reader.BytesConsumed..];
            leftOverLength = leftover.Length;
            if (leftOverLength == buffer.Length)
            {
                throw new InvalidOperationException("Too short");
            }

            leftover.CopyTo(buffer);
            endExcl = Math.Min(jsonSpan.Length, startIncl + chunkSize - leftOverLength);
            writtenBytes = Encoding.UTF8.GetBytes(jsonSpan[startIncl..endExcl], buffer[leftOverLength..]);
            startIncl += writtenBytes;
            endExcl = Math.Min(jsonSpan.Length, startIncl + chunkSize);
        }
        else
        {
            writtenBytes = Encoding.UTF8.GetBytes(jsonSpan[startIncl..endExcl], buffer);
            startIncl += writtenBytes;
            endExcl = Math.Min(jsonSpan.Length, startIncl + chunkSize);
        }
        bufferEnd = leftOverLength + writtenBytes;
        reader = new Utf8JsonReader(buffer[..bufferEnd], isFinalBlock: startIncl == jsonSpan.Length, reader.CurrentState);
    }

    public sealed class Target
    {
        [JsonPropertyName("property_1")]
        public int Value { get; set; }
    }
}