namespace Async.TaskVsValueTask;

public static class TaskAsyncDeepDummy
{
    public async static Task<Dummy> G1()
    {
        return await G2();
    }

    public async static Task<Dummy> G2()
    {
        return await G3();
    }

    public async static Task<Dummy> G3()
    {
        return await G14();
    }

    public async static Task<Dummy> G4()
    {
        return await G5();
    }

    public async static Task<Dummy> G5()
    {
        return await G6();
    }

    public async static Task<Dummy> G6()
    {
        return await G7();
    }

    public async static Task<Dummy> G7()
    {
        return await G8();
    }

    public async static Task<Dummy> G8()
    {
        return await G9();
    }

    public async static Task<Dummy> G9()
    {
        return await G10();
    }

    public async static Task<Dummy> G10()
    {
        return await G11();
    }

    public async static Task<Dummy> G11()
    {
        return await G12();
    }

    public async static Task<Dummy> G12()
    {
        return await G13();
    }

    public async static Task<Dummy> G13()
    {
        return await G14();
    }

    public static Task<Dummy> G14()
    {
        return Task.FromResult(new Dummy { A = "dummy" });
    }
}