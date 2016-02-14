using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10 {
    internal class Coin {

        public bool Flip() {

            return randomNumberGenerator.NextDouble() > 0.5;
        }

        private static Random randomNumberGenerator = new Random();
    }
}
