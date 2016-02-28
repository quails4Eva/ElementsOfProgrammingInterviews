using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class Test12_1 {

        [TestMethod]
        public void ReturnMinus1IfNotPresent() {

            Assert.AreEqual(-1, Problem12_1.BinarySearchFirstInstance(new[] { 12, }, 1));
            Assert.AreEqual(-1, Problem12_1.BinarySearchFirstInstance(new[] { 2, 12, }, 1));
            Assert.AreEqual(-1, Problem12_1.BinarySearchFirstInstance(new[] { 1, 2, 3, 5, }, 4));
            Assert.AreEqual(-1, Problem12_1.BinarySearchFirstInstance(new[] { 1, 12, }, -1));
            Assert.AreEqual(-1, Problem12_1.BinarySearchFirstInstance(new[] { -1, 1, 12, }, 0));
        }

        [TestMethod]
        public void UniqueElementFound() {

            Assert.AreEqual(0, Problem12_1.BinarySearchFirstInstance(new[] { 1, }, 1));
            Assert.AreEqual(1, Problem12_1.BinarySearchFirstInstance(new[] { 2, 12, }, 12));
            Assert.AreEqual(3, Problem12_1.BinarySearchFirstInstance(new[] { 1, 2, 3, 4, 5, }, 4));
            Assert.AreEqual(0, Problem12_1.BinarySearchFirstInstance(new[] { -1, 1, 12, }, -1));
            Assert.AreEqual(1, Problem12_1.BinarySearchFirstInstance(new[] { -1, 0, 1, 12, }, 0));
        }


        [TestMethod]
        public void MultipleCopiesOfElementFound() {

            Assert.AreEqual(0, Problem12_1.BinarySearchFirstInstance(new[] { 1, 1, }, 1));
            Assert.AreEqual(1, Problem12_1.BinarySearchFirstInstance(new[] { 2, 12, 12, 12, }, 12));
            Assert.AreEqual(5, Problem12_1.BinarySearchFirstInstance(new[] { 1, 1, 2, 2, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, }, 4));
            Assert.AreEqual(0, Problem12_1.BinarySearchFirstInstance(new[] { -1, -1, 1, 1, 1, 5, 12, 12, }, -1));
            Assert.AreEqual(1, Problem12_1.BinarySearchFirstInstance(new[] { -1, 0, 0, 1, 1, 1, 4, 12, 12, }, 0));
        }
    }
}
