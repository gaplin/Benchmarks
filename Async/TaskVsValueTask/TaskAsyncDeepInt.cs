namespace Async.TaskVsValueTask;

public static class TaskAsyncDeepInt
{
    public static async Task<int> G1()
    {
        return await G2();
    }

    public static async Task<int> G2()
    {
        return await G3();
    }

    public static async Task<int> G3()
    {
        return await G14();
    }

    public static async Task<int> G4()
    {
        return await G5();
    }

    public static async Task<int> G5()
    {
        return await G6();
    }

    public static async Task<int> G6()
    {
        return await G7();
    }

    public static async Task<int> G7()
    {
        return await G8();
    }

    public static async Task<int> G8()
    {
        return await G9();
    }

    public static async Task<int> G9()
    {
        return await G10();
    }

    public static async Task<int> G10()
    {
        return await G11();
    }

    public static async Task<int> G11()
    {
        return await G12();
    }

    public static async Task<int> G12()
    {
        return await G13();
    }

    public static async Task<int> G13()
    {
        return await G14();
    }

    public static Task<int> G14()
    {
        return Task.FromResult(9999999);
    }
}