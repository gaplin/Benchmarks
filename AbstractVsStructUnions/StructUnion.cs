namespace AbstractVsStructUnions;

public readonly struct StructUnion<T1, T2, T3>
{
    private readonly T1? _t1Value;
    private readonly T2? _t2Value;
    private readonly T3? _t3Value;
    private readonly int _index;

    public int Index => _index;

    public StructUnion(T1 value)
    {
        _t1Value = value;
        _index = 0;
    }

    public StructUnion(T2 value)
    {
        _t2Value = value;
        _index = 1;
    }

    public StructUnion(T3 value)
    {
        _t3Value = value;
        _index = 2;
    }

    public T1 AsT1 => _index == 0 ? _t1Value! : throw new InvalidOperationException();

    public T2 AsT2 => _index == 1 ? _t2Value! : throw new InvalidOperationException();
    public T3 AsT3 => _index == 2 ? _t3Value! : throw new InvalidOperationException();

    public static implicit operator StructUnion<T1, T2, T3>(T1 value) => new(value);
    public static implicit operator StructUnion<T1, T2, T3>(T2 value) => new(value);
    public static implicit operator StructUnion<T1, T2, T3>(T3 value) => new(value);
}