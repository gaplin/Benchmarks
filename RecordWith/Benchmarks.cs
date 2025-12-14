using BenchmarkDotNet.Attributes;

namespace RecordWith;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private List<string> _validIds = [];
    private List<Cls> _clsLst = [];
    private List<Rc> _rcLst = [];
    private List<RcStr> _rcStrLst = [];
    private List<Str> _strLst = [];
    private static Random s_rnd = new Random(500);

    [Params(1_000, 1_000_000)]
    public int Elements { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 100; i < 200; ++i)
        {
            _validIds.Add(i.ToString());
        }

        for (int i = 0; i < Elements; ++i)
        {
            int value = s_rnd.Next() % 1000 + 1;
            string key = _validIds[s_rnd.Next() % 100];
            _clsLst.Add(new Cls { Id = key, Value = value });
            _rcLst.Add(new(value, key));
            _rcStrLst.Add(new(value, key));
            _strLst.Add(new Str { Value = value, Id = key });
        }
    }

    [Benchmark(Baseline = true)]
    public List<Rc> Record()
    {
        Dictionary<string, Rc> groups = [];
        foreach (var item in _rcLst)
        {
            if (groups.TryGetValue(item.Id, out var dictValue))
            {
                groups[item.Id] = dictValue with { Value = dictValue.Value + item.Value };
            }
            else
            {
                groups[item.Id] = item;
            }
        }
        return [.. groups.Values];
    }

    [Benchmark]
    public List<Cls> Class()
    {
        Dictionary<string, Cls> groups = [];
        foreach (var item in _clsLst)
        {
            if (groups.TryGetValue(item.Id, out var dictValue))
            {
                dictValue.Value += item.Value;
            }
            else
            {
                groups[item.Id] = item;
            }
        }
        return [.. groups.Values];
    }

    [Benchmark]
    public List<RcStr> RecordStruct()
    {
        Dictionary<string, RcStr> groups = [];
        foreach (var item in _rcStrLst)
        {
            if (groups.TryGetValue(item.Id, out var dictValue))
            {
                groups[item.Id] = dictValue with { Value = dictValue.Value + item.Value };
            }
            else
            {
                groups[item.Id] = item;
            }
        }
        return [.. groups.Values];
    }

    [Benchmark]
    public List<Str> Struct()
    {
        Dictionary<string, Str> groups = [];
        foreach (var item in _strLst)
        {
            if (groups.TryGetValue(item.Id, out var dictValue))
            {
                groups[item.Id] = dictValue with { Value = dictValue.Value + item.Value };
            }
            else
            {
                groups[item.Id] = item;
            }
        }
        return [.. groups.Values];
    }
}

public class Cls
{
    public string Id { get; set; } = null!;
    public int Value { get; set; }
}

public record Rc(int Value, string Id);
public readonly record struct RcStr(int Value, string Id);

public struct Str
{
    public int Value;
    public string Id;
}