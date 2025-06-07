using BenchmarkDotNet.Attributes;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PolymorphicJsonSerialization;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    public string _discriminatorAtTheTop = null!;
    public string _discriminatorAtTheBottom = null!;
    private JsonSerializerOptions _options = null!;

    [Params(1_000, 1_000_000)]
    public int NumberOfItems { get; set; }
    [GlobalSetup]
    public void Setup()
    {
        StringBuilder _topBuilder = new("{");
        StringBuilder _botBuilder = new("{\"items\":{");
        const string discriminator = "\"$type\":\"derived\"";

        _topBuilder.Append($"{discriminator},\"items\":{{");

        for (int i = 0; i < NumberOfItems; ++i)
        {
            string item = $"\"{i}\":{i}";
            _topBuilder.Append(item);
            _botBuilder.Append(item);
            if (i != NumberOfItems - 1)
            {
                _topBuilder.Append(',');
                _botBuilder.Append(',');
            }
        }

        _topBuilder.Append("}}");
        _botBuilder.Append($"}},{discriminator}}}");
        _discriminatorAtTheTop = _topBuilder.ToString();
        _discriminatorAtTheBottom = _botBuilder.ToString();

        _options = new(JsonSerializerDefaults.Web)
        {
            AllowOutOfOrderMetadataProperties = true
        };
    }

    [Benchmark(Baseline = true)]
    public BaseClass AtTheTopWebDefault()
    {
        return JsonSerializer.Deserialize<BaseClass>(_discriminatorAtTheTop, JsonSerializerOptions.Web)!;
    }

    [Benchmark]
    public BaseClass AtTheBottomWebCustom()
    {
        return JsonSerializer.Deserialize<BaseClass>(_discriminatorAtTheBottom, _options)!;
    }

    [Benchmark]
    public BaseClass AtTheTopWebCustom()
    {
        return JsonSerializer.Deserialize<BaseClass>(_discriminatorAtTheTop, _options)!;
    }
}

[JsonPolymorphic]
[JsonDerivedType(typeof(DerivedClass), "derived")]
public abstract class BaseClass
{
}

public sealed class DerivedClass : BaseClass
{
    public Dictionary<string, int> Items { get; init; } = [];
}