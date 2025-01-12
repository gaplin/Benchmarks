namespace MatrixMulJaggedVsMulti;

public static class Variants
{
    public static void Jagged_Normal(int[,] a, int[,] b, int[,] c, int n)
    {
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                for (int k = 0; k < n; ++k)
                {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }
    }

    public static void Jagged_Changed(int[,] a, int[,] b, int[,] c, int n)
    {
        for (int i = 0; i < n; ++i)
        {
            for (int k = 0; k < n; ++k)
            {
                for (int j = 0; j < n; ++j)
                {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }
    }

    public static void Multi_Normal(int[][] a, int[][] b, int[][] c, int n)
    {
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                for (int k = 0; k < n; ++k)
                {
                    c[i][j] += a[i][k] * b[k][j];
                }
            }
        }
    }

    public static void Multi_Changed(int[][] a, int[][] b, int[][] c, int n)
    {
        for (int i = 0; i < n; ++i)
        {
            for (int k = 0; k < n; ++k)
            {
                for (int j = 0; j < n; ++j)
                {
                    c[i][j] += a[i][k] * b[k][j];
                }
            }
        }
    }

    public static void Flat_Normal(int[] a, int[] b, int[] c, int n)
    {
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                for (int k = 0; k < n; ++k)
                {
                    c[i * n + j] += a[i * n + k] * b[k * n + j];
                }
            }
        }
    }

    public static void Flat_Changed(int[] a, int[] b, int[] c, int n)
    {
        for (int i = 0; i < n; ++i)
        {
            for (int k = 0; k < n; ++k)
            {
                for (int j = 0; j < n; ++j)
                {
                    c[i * n + j] += a[i * n + k] * b[k * n + j];
                }
            }
        }
    }
}