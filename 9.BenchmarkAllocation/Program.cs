using System;
using System.Diagnostics;
namespace Exercises
{
    class BenchmarkAllocation
    {
        const int _max = 100000;
        static void Main(string[] args)
        {
            var Arr2D = new int[100, 100];
            var ArrJagged = new int[100][];
            for (int i = 0; i < 100; i++)
            {
                ArrJagged[i] = new int[100];
            }
            var Stopwatch2D = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        Arr2D[j, k] = k;
                    }
                }
            }
            Stopwatch2D.Stop();
            var StopwatchJagged = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        ArrJagged[j][k] = k;
                    }
                }
            }
            StopwatchJagged.Stop();
            Console.Write("\n Time taken for allocation in case of 2D array: ");
            Console.WriteLine(Stopwatch2D.Elapsed.TotalMilliseconds + " milliseconds");
            Console.Write("\n Time taken for allocation in case of Jagged array: ");
            Console.WriteLine(StopwatchJagged.Elapsed.TotalMilliseconds + " milliseconds");
        }
    }
}