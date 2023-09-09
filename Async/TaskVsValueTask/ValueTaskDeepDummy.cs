namespace Async.TaskVsValueTask;

public static class ValueTaskDeepDummy
{
    public static ValueTask<Dummy> F1()
    {
        return F2();
    }

    public static ValueTask<Dummy> F2()
    {
        return F3();
    }

    public static ValueTask<Dummy> F3()
    {
        return F14();
    }

    public static ValueTask<Dummy> F4()
    {
        return F5();
    }

    public static ValueTask<Dummy> F5()
    {
        return F6();
    }

    public static ValueTask<Dummy> F6()
    {
        return F7();
    }

    public static ValueTask<Dummy> F7()
    {
        return F8();
    }

    public static ValueTask<Dummy> F8()
    {
        return F9();
    }

    public static ValueTask<Dummy> F9()
    {
        return F10();
    }

    public static ValueTask<Dummy> F10()
    {
        return F11();
    }

    public static ValueTask<Dummy> F11()
    {
        return F12();
    }

    public static ValueTask<Dummy> F12()
    {
        return F13();
    }

    public static ValueTask<Dummy> F13()
    {
        return F14();
    }

    public static ValueTask<Dummy> F14()
    {
        return ValueTask.FromResult(new Dummy { A = "dummy" });
    }
}