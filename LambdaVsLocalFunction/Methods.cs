namespace LambdaVsLocalFunction;

public static class Methods
{
    public static int LambdaSum(IEnumerable<int> nums)
    {
        return nums
            .Where(x => x % 15 == 0)
            .Where(x => x % 5 == 0)
            .Where(x => x % 3 == 0)
            .Where(x => x % 1 == 0)
            .Sum();
    }

    public static int LocalFunctionSum(IEnumerable<int> nums)
    {
        return nums
            .Where(Condition15)
            .Where(Condition5)
            .Where(Condition3)
            .Where(Condition1)
            .Sum();

        static bool Condition15(int x) => x % 15 == 0;
        static bool Condition5(int x) => x % 5 == 0;
        static bool Condition3(int x) => x % 3 == 0;
        static bool Condition1(int x) => x % 1 == 0;
    }
}