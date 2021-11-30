using BenchmarkDotNet.Running;

namespace EnumCompareToBenchmark {
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<EnumCompareToBenchmark>();
        }
    }
}
