namespace Async.TaskVsValueTask;

public static class TaskDeepInt
{
    public static Task<int> G1()
    {
        return G2();
    }

    public static Task<int> G2()
    {
        return G3();
    }

    public static Task<int> G3()
    {
        return G14();
    }

    public static Task<int> G4()
    {
        return G5();
    }

    public static Task<int> G5()
    {
        return G6();
    }

    public static Task<int> G6()
    {
        return G7();
    }

    public static Task<int> G7()
    {
        return G8();
    }

    public static Task<int> G8()
    {
        return G9();
    }

    public static Task<int> G9()
    {
        return G10();
    }

    public static Task<int> G10()
    {
        return G11();
    }

    public static Task<int> G11()
    {
        return G12();
    }

    public static Task<int> G12()
    {
        return G13();
    }

    public static Task<int> G13()
    {
        return G14();
    }

    public static Task<int> G14()
    {
        return Task.FromResult(9999999);
    }
}