namespace Async.TaskVsValueTask;

public static class ValueTaskDeepInt
{
    public static ValueTask<int> F1()
    {
        return F2();
    }

    public static ValueTask<int> F2()
    {
        return F3();
    }

    public static ValueTask<int> F3()
    {
        return F14();
    }

    public static ValueTask<int> F4()
    {
        return F5();
    }

    public static ValueTask<int> F5()
    {
        return F6();
    }

    public static ValueTask<int> F6()
    {
        return F7();
    }

    public static ValueTask<int> F7()
    {
        return F8();
    }

    public static ValueTask<int> F8()
    {
        return F9();
    }

    public static ValueTask<int> F9()
    {
        return F10();
    }

    public static ValueTask<int> F10()
    {
        return F11();
    }

    public static ValueTask<int> F11()
    {
        return F12();
    }

    public static ValueTask<int> F12()
    {
        return F13();
    }

    public static ValueTask<int> F13()
    {
        return F14();
    }

    public static ValueTask<int> F14()
    {
        return ValueTask.FromResult(9999999);
    }
}