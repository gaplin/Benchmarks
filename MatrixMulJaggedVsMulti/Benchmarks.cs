using BenchmarkDotNet.Attributes;

namespace MatrixMulJaggedVsMulti;

public class Benchmarks
{
    [Params(1000)]
    public int N { get; set; }

    private readonly Random _rand = new(6420);

    private int[,] _jagged_a = null!;
    private int[,] _jagged_b = null!;
    private int[,] _jagged_c = null!;

    private int[][] _multi_a = null!;
    private int[][] _multi_b = null!;
    private int[][] _multi_c = null!;

    private int[] _flat_a = null!;
    private int[] _flat_b = null!;
    private int[] _flat_c = null!;

    private int _target_row;
    private int _target_col;

    [GlobalSetup]
    public void Setup()
    {
        _jagged_a = new int[N, N];
        _jagged_b = new int[N, N];
        _jagged_c = new int[N, N];

        _multi_a = new int[N][];
        _multi_b = new int[N][];
        _multi_c = new int[N][];
        for (int i = 0; i < N; ++i)
        {
            _multi_a[i] = new int[N];
            _multi_b[i] = new int[N];
            _multi_c[i] = new int[N];
        }

        _flat_a = new int[N * N];
        _flat_b = new int[N * N];
        _flat_c = new int[N * N];

        for (int i = 0; i < N; ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                int val_a = _rand.Next() % 10 + 1;
                int val_b = _rand.Next() % 10 + 1;

                _jagged_a[i, j] = val_a;
                _jagged_b[i, j] = val_b;

                _multi_a[i][j] = val_a;
                _multi_b[i][j] = val_b;

                _flat_a[i * N + j] = val_a;
                _flat_b[i * N + j] = val_b;
            }
        }
        _target_col = _rand.Next() % N;
        _target_row = _rand.Next() % N;
    }

    [Benchmark(Baseline = true)]
    public int JaggedArraysNormal()
    {
        Variants.Jagged_Normal(_jagged_a, _jagged_b, _jagged_c, N);
        return _jagged_c[_target_row, _target_col];
    }

    [Benchmark]
    public int JaggedArraysChanged()
    {
        Variants.Jagged_Changed(_jagged_a, _jagged_b, _jagged_c, N);
        return _jagged_c[_target_row, _target_col];
    }

    [Benchmark]
    public int MultiDimArraysNormal()
    {
        Variants.Multi_Normal(_multi_a, _multi_b, _multi_c, N);
        return _multi_c[_target_row][_target_col];
    }

    [Benchmark]
    public int MultiDimArraysChanged()
    {
        Variants.Multi_Changed(_multi_a, _multi_b, _multi_c, N);
        return _multi_c[_target_row][_target_col];
    }

    [Benchmark]
    public int FlatArrayNormal()
    {
        Variants.Flat_Normal(_flat_a, _flat_b, _flat_c, N);
        return _flat_c[_target_row * N + _target_col];
    }

    [Benchmark]
    public int FlatArrayChanged()
    {
        Variants.Flat_Changed(_flat_a, _flat_b, _flat_c, N);
        return _flat_c[_target_row * N + _target_col];
    }
}
