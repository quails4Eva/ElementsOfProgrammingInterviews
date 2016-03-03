using _14._1;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class Test14_1 {
        [TestMethod]
        public void Test14_1Intersection() {

            var array1 = new[] { 1, 1, 1, 2, 3, 4, 5, 7, 7, 10 };
            var array2 = new[] { 1, 1, 2, 2, 3, 4, 6, 7, 9, 9, 10, 11, 11, 25 };

            Assert.IsTrue(Enumerable.SequenceEqual(Problem14_1.GetSortedArrayIntersection(array1, array2), Problem14_1.GetSortedArrayIntersection1(array1, array2)));
        }
    }
}
