namespace Forwading;

internal static class PlayGround
{
    public static async Task AwaitStuff(int iterations, int taskSize)
    {
        await DoStuff(iterations, taskSize);
    }

    public static Task PassToStuff(int iterations, int taskSize)
        => DoStuff(iterations, taskSize);
    
    private static Task DoStuff(int iterations, int taskSize)
    {
        return Task.Run(() =>
        {
            while(iterations-- > 0)
            {
                _ = Enumerable.Range(0, taskSize).ToList();
            }
        });
    } 
}