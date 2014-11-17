using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncHelper
{
    class Program
    {
        private static int multiplier = 1;

        static void Main(string[] args)
        {
            DateTime t1 = DateTime.Now;
            PrintPrimaryNumbers();
            var ts1 = DateTime.Now.Subtract(t1);
            Trace.WriteLine("Finished Sync and started Async");
            var t2 = DateTime.Now;
            PrintPrimaryNumbersAsync();
            var ts2 = DateTime.Now.Subtract(t2);

            Trace.WriteLine(string.Format(
              "It took {0} for the sync call and {1} for the Async one", ts1, ts2));

            Trace.WriteLine("Any Key to terminate!!");
        }

        private static void PrintPrimaryNumbers()
        {
            for (int i = 0; i < 10; i++)
                getPrimes(i * multiplier + 1, i * multiplier * 10)
                    .ToList().
                    ForEach(x => Trace.WriteLine(x));
        }
        public static IEnumerable<int> getPrimes(int min, int count)
        {
            return Enumerable.Range(min, count).Where
              (n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i =>
                n % i > 0));
        }

        private static async void PrintPrimaryNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                var result = await getPrimesAsync(i * multiplier + 1, i * multiplier * 10);
                result.ToList().ForEach(x => Trace.WriteLine(x));
            }
        }
        public static Task<IEnumerable<int>> getPrimesAsync(int min, int count)
        {
            return Task.Run(() => Enumerable.Range(min, count).Where
             (n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i =>
               n % i > 0)));
        }
    }
}
