namespace DynamicDispatch;

public interface ITest
{
    long GetValue();
}

public class ATest : ITest
{
    public int Value { get; set; }

    public virtual long GetValue()
    {
        return Value;
    }
}

public class AATest : ATest
{
    public override long GetValue()
    {
        return Value + 5;
    }
}

public class BTest : ITest
{
    public int Value { get; set; }

    public long GetValue()
    {
        return Value - 1;
    }
}

public class NoInheritance
{
    public int Type { get; set; }
    public int Value { get; set; }
    public long GetValue()
    {
        return Type switch
        {
            0 => Value,
            1 => Value + 5,
            2 => Value - 1,
            _ => throw new InvalidOperationException($"Unsupported type {Type}")
        };
    }
}

public static class Functions
{
    public static long GetCorrectValue(ATest obj)
    {
        return obj.Value;
    }
    public static long GetCorrectValue(AATest obj)
    {
        return obj.Value + 5;
    }
    public static long GetCorrectValue(BTest obj)
    {
        return obj.Value - 1;
    }
}