namespace PassingDelegatesVsObjects;

public sealed class Calculator
{
    private readonly IAdder? _adderInterface;
    private readonly Adder? _adderDirect;
    private readonly Add? _adderDelegate;

    public Calculator(Adder adderDirect)
    {
        _adderDirect = adderDirect;
    }

    public Calculator(Add adderDelegate)
    {
        _adderDelegate = adderDelegate;
    }

    public Calculator(IAdder adder)
    {
        _adderInterface = adder;
    }

    public long AddInterface(int a, int b) => _adderInterface!.Add(a, b);
    public long AddDirectObject(int a, int b) => _adderDirect!.Add(a, b);
    public long AddDelegate(int a, int b) => _adderDelegate!.Invoke(a, b);
}

public interface IAdder
{
    long Add(int a, int b);
}

public sealed class Adder : IAdder
{
    public long Add(int a, int b)
    {
        return a + b;
    }
}

public delegate long Add(int a, int b);