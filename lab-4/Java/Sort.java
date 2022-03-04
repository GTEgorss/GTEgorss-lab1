package src.main.java;

import org.openjdk.jmh.annotations.*;

import java.util.Arrays;
import java.util.Random;
import java.util.concurrent.TimeUnit;

@BenchmarkMode(Mode.All)
@OutputTimeUnit(TimeUnit.MICROSECONDS)
@State(Scope.Thread)
public class Sort {
    private int[] _arr;

    public Sort() {
        _arr = new int[500];
        RandomizeArray();
    }

    private void RandomizeArray() {
        for (int i = 0; i < _arr.length; ++i) {
            _arr[i] = new Random().nextInt(500);
        }
    }

    @Benchmark
    public int[] BubbleSortBenchmark() {
        RandomizeArray();
        IAlgorithm alg = new BubbleSort();
        return alg.Sort(_arr);
    }

    @Benchmark
    public int[] MergeSortBenchmark() {
        RandomizeArray();
        IAlgorithm alg = new MergeSort();
        return alg.Sort(_arr);
    }

    @Benchmark
    public int[] QuickSortBenchmark() {
        RandomizeArray();
        IAlgorithm alg = new QuickSort();
        return alg.Sort(_arr);
    }

    @Benchmark
    public int[] DefaultSortBenchmark() {
        RandomizeArray();
        Arrays.sort(_arr);
        return _arr;
    }
}
