using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Csharp_4
{
    [SimpleJob(RunStrategy.Throughput, launchCount: 5)]
    [MemoryDiagnoser]
    public class Sort
    {
        private int[] _arr;

        public Sort()
        {
            _arr = new int[500];
            for (int i = 0; i < 500; ++i)
            {
                _arr[i] = i;
            }
        }

        private void ShuffleArray()
        {
            Random random = new Random();
            _arr = _arr.OrderBy(i => random.Next()).ToArray();
        }

        [Benchmark(Description = "BubbleSortBenchmark")]
        public int[] BubbleSortBenchmark()
        {
            ShuffleArray();
            IAlgorithm alg = new BubbleSort();
            alg.Sort(_arr);
            return _arr;
        }
        
        [Benchmark(Description = "MergeSortBenchmark")]
        public int[] MergeSortBenchmark()
        {
            ShuffleArray();
            IAlgorithm alg = new MergeSort();
            alg.Sort(_arr);
            return _arr;
        }
        
        [Benchmark(Description = "QuickSortBenchmark")]
        public int[] QuickSortBenchmark()
        {
            ShuffleArray();
            IAlgorithm alg = new QuickSort();
            alg.Sort(_arr);
            return _arr;
        }
        
        [Benchmark(Description = "ArraySortBenchmark")]
        public int[] DefaultSortBenchmark()
        {
            ShuffleArray();
            Array.Sort(_arr);
            return _arr;
        }
    }
}
