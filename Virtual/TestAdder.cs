namespace Virtual;

public interface ITestAdder
{
    int Add(int a, int b);
}

public class TestAdderI : ITestAdder
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

public abstract class ATestAdder
{
    public abstract int Add(int a, int b);
}

public class TestAdderA : ATestAdder
{
    public override int Add(int a, int b)
    {
        return a + b;
    }
}

public class TestAdder
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
