using BenchmarkDotNet.Running;
using WorkItems.Benchmarks;

namespace WorkItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ExercisesBenchmark>();
        }
    }
}
