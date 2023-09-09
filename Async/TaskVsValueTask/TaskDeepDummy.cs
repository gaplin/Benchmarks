namespace Async.TaskVsValueTask;

public static class TaskDeepDummy
{
    public static Task<Dummy> G1()
    {
        return G2();
    }

    public static Task<Dummy> G2()
    {
        return G3();
    }

    public static Task<Dummy> G3()
    {
        return G14();
    }

    public static Task<Dummy> G4()
    {
        return G5();
    }

    public static Task<Dummy> G5()
    {
        return G6();
    }

    public static Task<Dummy> G6()
    {
        return G7();
    }

    public static Task<Dummy> G7()
    {
        return G8();
    }

    public static Task<Dummy> G8()
    {
        return G9();
    }

    public static Task<Dummy> G9()
    {
        return G10();
    }

    public static Task<Dummy> G10()
    {
        return G11();
    }

    public static Task<Dummy> G11()
    {
        return G12();
    }

    public static Task<Dummy> G12()
    {
        return G13();
    }

    public static Task<Dummy> G13()
    {
        return G14();
    }

    public static Task<Dummy> G14()
    {
        return Task.FromResult(new Dummy { A = "dummy" });
    }
}