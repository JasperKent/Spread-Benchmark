using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadBenchmark
{
    [MemoryDiagnoser]
    public class Tests
    {
        private readonly int[] _data = new int[10_000];

        [Benchmark(Baseline = true)]
        public int[] WithToArray()
        {
            int[] results = _data.ToArray();

            return results;
        }

        [Benchmark]
        public int[] WithCopyTo()
        {
            int[] results = new int[_data.Length];

            _data.CopyTo(results, 0);

            return results;
        }

        [Benchmark]
        public int[] WithSpread()
        {
            int[] results = [.._data];

            return results;
        }
    }
}
