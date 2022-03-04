using BenchmarkDotNet.Running;

namespace Csharp_4
{
    public static class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Sort>();
        }
    }
}
