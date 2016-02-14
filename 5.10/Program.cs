using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10 {
    class Program {
        static void Main(string[] args) {

            var random = new Random();

            for (int i = 0; i < 10000; i++) {

                var a1 = random.Next(10000);
                var b1 = random.Next(10000);
                var a = Math.Min(a1, b1);
                var b = Math.Max(a1, b1);
                var range = b - a + 1;

                var results = new int[range];
                var iterationsPerABPair = 100000;

                for (int j = 0; j < iterationsPerABPair; j++) {


                    var result = Problem5_10.GetUniformRandomNumber(a, b);

                    if (result < a || result > b) {
                        Console.WriteLine($"Failure for {a} and {b}, got result {result}");
                        throw new Exception($"Failure to generate random number for range {a} to {b}, got result {result}");
                    }

                    results[result - a]++;
                }

                foreach (var num in results) {

                    var x = (num);
                    var y = ((double)iterationsPerABPair / range);
                    var differenceFromExpectedFrequency = Math.Abs((x - y) / iterationsPerABPair);

                    if (differenceFromExpectedFrequency > 0.002) {

                        Console.WriteLine($"Value fell out of the expected frequency range freq: {differenceFromExpectedFrequency}, a: {a}, b: {b}");
                    }
                }
            }
        }
    }
}
