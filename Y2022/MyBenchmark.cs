using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Y2022.ForBenchmarkCode;

namespace Y2022
{
    public class MyBenchmark
    {
        private IDay day02v1 = new Day02v1();
        private IDay day02v2 = new Day02v2();
        private IDay day02v3 = new Day02();

        [Benchmark]
        public int TestDay02v1() => day02v1.Part2();

        [Benchmark]
        public int TestDay02v2() => day02v2.Part2();

        [Benchmark]
        public int TestDay02v3() => day02v3.Part2();
    }
}
