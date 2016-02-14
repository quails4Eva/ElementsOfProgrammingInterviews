using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10 {
    public static class Problem5_10 {
        public static int GetUniformRandomNumber(int a, int b) {

            // Could validate inputs here - e.g. a < b; a, b > 0; etc.

            var range = b - a;
            var numberOfOptions = range + 1;

            int generatedNumber = range + 1;

            while (generatedNumber > range) {

                generatedNumber = 0;

                int flipsSelectivity = 1;

                // Todo - fix below
                while (flipsSelectivity < numberOfOptions) {

                    generatedNumber += flipsSelectivity * GetCoinFlipAs0Or1();
                    flipsSelectivity *= 2;
                }
            }

            return generatedNumber + a;
        }

        private static int GetCoinFlipAs0Or1() {
            return coin.Flip() ? 1 : 0;
        }

        private static Coin coin = new Coin();
    }
}
