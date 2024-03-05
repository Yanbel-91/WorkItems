using BenchmarkDotNet.Attributes;

namespace WorkItems.Benchmarks
{
    [MemoryDiagnoser]
    public class ExercisesBenchmark
    {
        [Benchmark]
        public void ExerciseOneBenchmark()
        {
            List<string> list = [ "Beta", "Gamma", "Alpha", "Epsilon"];
            list = Exercises.ExerciseOne(list);
        }

        [Benchmark]
        public void ExerciseOneBenchmarkControlGroup()
        {
            List<string> list = ["Beta", "Gamma", "Alpha", "Epsilon"];
            list.Sort();
        }
    }
}
