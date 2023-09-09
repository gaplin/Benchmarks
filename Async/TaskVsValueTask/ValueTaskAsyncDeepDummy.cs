namespace Async.TaskVsValueTask;

public static class ValueTaskAsyncDeepDummy
{
    public static async ValueTask<Dummy> F1()
    {
        return await F2();
    }

    public static async ValueTask<Dummy> F2()
    {
        return await F3();
    }

    public static async ValueTask<Dummy> F3()
    {
        return await F14();
    }

    public static async ValueTask<Dummy> F4()
    {
        return await F5();
    }

    public static async ValueTask<Dummy> F5()
    {
        return await F6();
    }

    public static async ValueTask<Dummy> F6()
    {
        return await F7();
    }

    public static async ValueTask<Dummy> F7()
    {
        return await F8();
    }

    public static async ValueTask<Dummy> F8()
    {
        return await F9();
    }

    public static async ValueTask<Dummy> F9()
    {
        return await F10();
    }

    public static async ValueTask<Dummy> F10()
    {
        return await F11();
    }

    public static async ValueTask<Dummy> F11()
    {
        return await F12();
    }

    public static async ValueTask<Dummy> F12()
    {
        return await F13();
    }

    public static async ValueTask<Dummy> F13()
    {
        return await F14();
    }

    public static ValueTask<Dummy> F14()
    {
        return ValueTask.FromResult(new Dummy { A = "dummy" });
    }
}