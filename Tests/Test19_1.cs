using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class Test19_1 {

        [TestMethod]
        public void TestHasExit() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { false, false, true, }, // x = 0
                { false, true, true, }, // x = 1
                { true, true, false, }, // x = 2
            };

            Assert.IsTrue(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 2), Tuple.Create(2, 0)));
        }

        [TestMethod]
        public void TestHasExit1() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { true, true, true, }, // x = 0
                { true, false, true, }, // x = 1
                { true, true, true, }, // x = 2
            };

            Assert.IsTrue(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 2), Tuple.Create(2, 0)));
        }

        [TestMethod]
        public void TestHasExit2() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { true, false, true, }, // x = 0
                { true, false, true, }, // x = 1
                { true, true, true, }, // x = 2
            };

            Assert.IsTrue(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 0), Tuple.Create(0, 2)));
        }

        [TestMethod]
        public void TestHasExit3() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { true, false, true, true, }, // x = 0
                { true, false, true, true, }, // x = 1
                { true, true, true, true, }, // x = 2
                { true, true, false, true, }, // x = 3
            };

            Assert.IsTrue(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 0), Tuple.Create(3, 3)));
        }

        [TestMethod]
        public void TestHasNoExit() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { true, false, true, }, // x = 0
                { true, false, true, }, // x = 1
                { true, false, true, }, // x = 2
            };

            Assert.IsFalse(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 0), Tuple.Create(0, 2)));
        }

        [TestMethod]
        public void TestHasNoExit2() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { true, false, true, }, // x = 0
                { true, false, false, }, // x = 1
                { true, true, true, }, // x = 2
            };

            Assert.IsFalse(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 0), Tuple.Create(0, 2)));
        }

        [TestMethod]
        public void TestHasNoExitExitIsWall() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { true, false, false, }, // x = 0
                { true, false, true, }, // x = 1
                { true, true, true, }, // x = 2
            };

            Assert.IsFalse(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 0), Tuple.Create(0, 2)));
        }

        [TestMethod]
        public void TestHasNoExit3() {

            var array = new bool[,] { // x and y are opposite of their intuitive visual representation when thinking of the indicies as x,y coordinates
                { true, false, true, false }, // x = 0
                { true, false, false, true }, // x = 1
                { true, true, true, false }, // x = 2
                { true, true, true, false }, // x = 3
            };

            Assert.IsFalse(Problem19_1.ArrayHasPath(array, Tuple.Create(0, 0), Tuple.Create(0, 2)));
        }
    }
}
