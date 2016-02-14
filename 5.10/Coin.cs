using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10 {
    internal class Coin {

        public bool Flip() {

            return randomNumberGenerator.Next(0, 2) == 1;
        }

        private static Random randomNumberGenerator = new Random();
    }
}
