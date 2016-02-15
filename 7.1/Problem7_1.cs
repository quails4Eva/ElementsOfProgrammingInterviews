using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1 {
    public static class Problem7_1 {

        public static int StringToInt(string input) {

            if (string.IsNullOrWhiteSpace(input)) {
                return 0;
            }

            int output = 0;
            int parity = input[0] == '-' ? -1 : 1;

            int index = 1;

            foreach (var character in input.SkipWhile(c => c == '-').Reverse()) {

                output += (character - '0') * index;
                index *= 10;
            }

            return output * parity;
        }

        public static string IntToString(int input) {

            if (input == 0) {
                return "0";
            }

            StringBuilder output = new StringBuilder();

            bool isNegative = (input < 0);

            input = Math.Abs(input);

            while (input > 0) {

                output.Append((input % 10));
                input /= 10;
            }

            if (isNegative) {
                output.Append('-');
            }

            var outputArray = new string[output.Length];

            return new string(output.ToString().Reverse().ToArray()); // Could probably do this more efficiently using manual array allocation
        }
    }
}
