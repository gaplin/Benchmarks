namespace Iteration;

public static class Funcs
{
    public static bool ForeachString(string str)
    {
        foreach (var c in str)
        {
            if (char.IsAsciiDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    public static bool ForString(string str)
    {
        for (int i = 0; i < str.Length; ++i)
        {
            if (char.IsAsciiDigit(str[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool ForStringLengthOutside(string str)
    {
        int limit = str.Length;
        for (int i = 0; i < limit; ++i)
        {
            if (char.IsAsciiDigit(str[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool ForeachSpan(ReadOnlySpan<char> str)
    {
        foreach (var c in str)
        {
            if (char.IsAsciiDigit(c))
            {
                return false;
            }
        }
        return true;
    }

    public static bool ForSpan(ReadOnlySpan<char> str)
    {
        for (int i = 0; i < str.Length; ++i)
        {
            if (char.IsAsciiDigit(str[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool ForSpanLengthOutside(ReadOnlySpan<char> str)
    {
        int length = str.Length;
        for (int i = 0; i < length; ++i)
        {
            if (char.IsAsciiDigit(str[i]))
            {
                return false;
            }
        }
        return true;
    }
}