using BenchmarkDotNet.Attributes;
using ProtoBuf;
using System.Text;

namespace SerializationComparison;

[MemoryDiagnoser(false)]
[GroupBenchmarksBy(BenchmarkDotNet.Configs.BenchmarkLogicalGroupRule.ByCategory)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net80)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net90, baseline: true)]
public class Benchmarks
{
    private readonly List<A> _items = [];
    private readonly Random _random = new(666);
    private string _systemTextResult = "";
    private string _newtonsoftResult = "";
    private byte[] _protoResult = [];

    [Params(1_000)]
    public int Count { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        char[] chars = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'w', 'v', 'x', 'y', 'z'];
        for (int i = 0; i < Count; ++i)
        {
            var a = new A
            {
                Id = Guid.NewGuid(),
                Texts = [],
                Date = DateTime.UtcNow,
                Dict = []
            };
            _items.Add(a);
            for (int j = 1_000; j < 1_100; ++j)
            {
                var builder = new StringBuilder();
                for (int k = 0; k < 126; ++k)
                {
                    builder.Append(chars[_random.Next() % 26]);
                }
                a.Texts.Add(builder.ToString());

                var b = new B
                {
                    BigNum = long.MaxValue - _random.NextInt64(),
                    Float = float.MaxValue - _random.Next(),
                    Double = _random.NextDouble(),
                    Bytes = new byte[1000],
                    Decimal = (decimal)(_random.NextDouble() - _random.NextDouble()),
                };
                _random.NextBytes(b.Bytes);
                a.Dict[j.ToString()] = b;
            }
        }
        _systemTextResult = SystemTextSerialization();
        _newtonsoftResult = NewtonsoftJsonSerialization();
        _protoResult = ProtobufSerialization().ToArray();
    }

    [Benchmark(Baseline = true), BenchmarkCategory("Serialization")]
    public string SystemTextSerialization()
    {
        return System.Text.Json.JsonSerializer.Serialize(_items);
    }

    [Benchmark, BenchmarkCategory("Serialization")]
    public string NewtonsoftJsonSerialization()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(_items);
    }

    [Benchmark, BenchmarkCategory("Serialization")]
    public MemoryStream ProtobufSerialization()
    {
        var stream = new MemoryStream();
        Serializer.Serialize(stream, _items);
        return stream;
    }

    [Benchmark(Baseline = true), BenchmarkCategory("Deserialization")]
    public List<A> SystemTextDeserialization()
    {
        return System.Text.Json.JsonSerializer.Deserialize<List<A>>(_systemTextResult)!;
    }

    [Benchmark, BenchmarkCategory("Deserialization")]
    public List<A> NewtonsoftJsonDeserialization()
    {
        return Newtonsoft.Json.JsonConvert.DeserializeObject<List<A>>(_newtonsoftResult)!;
    }

    [Benchmark, BenchmarkCategory("Deserialization")]
    public List<A> ProtobufDeserialization()
    {
        return Serializer.Deserialize<List<A>>(_protoResult.AsSpan());
    }
}

[ProtoContract]
public class A
{
    [ProtoMember(1)]
    public required Guid Id { get; init; }

    [ProtoMember(2)]
    public required List<string> Texts { get; init; }

    [ProtoMember(3)]
    public required DateTime Date { get; init; }

    [ProtoMember(4)]
    public required Dictionary<string, B> Dict { get; init; }
}

[ProtoContract]
public class B
{
    [ProtoMember(1)]
    public required long BigNum { get; init; }

    [ProtoMember(2)]
    public required float Float { get; init; }

    [ProtoMember(3)]
    public required double Double { get; init; }

    [ProtoMember(4)]
    public required decimal Decimal { get; init; }

    [ProtoMember(5)]
    public required byte[] Bytes { get; init; }
}
