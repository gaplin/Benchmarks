namespace Async.TaskVsValueTask;

public static class TaskAsyncDeepInt
{
    public async static Task<int> G1()
    {
        return await G2();
    }

    public async static Task<int> G2()
    {
        return await G3();
    }

    public async static Task<int> G3()
    {
        return await G14();
    }

    public async static Task<int> G4()
    {
        return await G5();
    }

    public async static Task<int> G5()
    {
        return await G6();
    }

    public async static Task<int> G6()
    {
        return await G7();
    }

    public async static Task<int> G7()
    {
        return await G8();
    }

    public async static Task<int> G8()
    {
        return await G9();
    }

    public async static Task<int> G9()
    {
        return await G10();
    }

    public async static Task<int> G10()
    {
        return await G11();
    }

    public async static Task<int> G11()
    {
        return await G12();
    }

    public async static Task<int> G12()
    {
        return await G13();
    }

    public async static Task<int> G13()
    {
        return await G14();
    }

    public static Task<int> G14()
    {
        return Task.FromResult(9999999);
    }
}