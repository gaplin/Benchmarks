namespace Async.TaskVsValueTask;

public static class ValueTaskAsyncDeepInt
{
    public static async ValueTask<int> F1()
    {
        return await F2();
    }

    public static async ValueTask<int> F2()
    {
        return await F3();
    }

    public static async ValueTask<int> F3()
    {
        return await F14();
    }

    public static async ValueTask<int> F4()
    {
        return await F5();
    }

    public static async ValueTask<int> F5()
    {
        return await F6();
    }

    public static async ValueTask<int> F6()
    {
        return await F7();
    }

    public static async ValueTask<int> F7()
    {
        return await F8();
    }

    public static async ValueTask<int> F8()
    {
        return await F9();
    }

    public static async ValueTask<int> F9()
    {
        return await F10();
    }

    public static async ValueTask<int> F10()
    {
        return await F11();
    }

    public static async ValueTask<int> F11()
    {
        return await F12();
    }

    public static async ValueTask<int> F12()
    {
        return await F13();
    }

    public static async ValueTask<int> F13()
    {
        return await F14();
    }

    public static ValueTask<int> F14()
    {
        return ValueTask.FromResult(9999999);
    }
}