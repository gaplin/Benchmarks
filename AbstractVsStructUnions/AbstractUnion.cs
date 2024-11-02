namespace AbstractVsStructUnions;

public abstract class AbstractUnion<T1, T2, T3>
{
    private AbstractUnion()
    { }

    public sealed class First(T1 value) : AbstractUnion<T1, T2, T3>
    {
        public T1 Value { get; } = value;
    }

    public sealed class Second(T2 value) : AbstractUnion<T1, T2, T3>
    {
        public T2 Value { get; } = value;
    }

    public sealed class Third(T3 value) : AbstractUnion<T1, T2, T3>
    {
        public T3 Value { get; } = value;
    }

    public static implicit operator AbstractUnion<T1, T2, T3>(T1 value) => new First(value);
    public static implicit operator AbstractUnion<T1, T2, T3>(T2 value) => new Second(value);
    public static implicit operator AbstractUnion<T1, T2, T3>(T3 value) => new Third(value);
}