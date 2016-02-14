using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10 {
    class Program {
        static void Main(string[] args) {

            var random = new Random();

            for (int i = 0; i < 100000; i++) {

                var a1 = random.Next(1000000);
                var b1 = random.Next(1000000);
                var a = Math.Min(a1, b1);
                var b = Math.Max(a1, b1);

                var result = Problem5_10.GetUniformRandomNumber(a, b);

                if (result < a || result > b) {
                    Console.WriteLine($"Failure for {a} and {b}, got result {result}");
                    throw new Exception($"Failure to generate random number for range {a} to {b}, got result {result}");
                }
            }
        }
    }
}
