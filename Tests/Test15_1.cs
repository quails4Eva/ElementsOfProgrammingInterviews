using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _15._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class Test15_1 {

        [TestMethod]
        public void TestEmpty() {

            var testData = new BSTNode<int>() { Data = 1 };

            Assert.IsTrue(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestLeftNodeSmaller() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Left = new BSTNode<int>() { Data = 0, }
            };

            Assert.IsTrue(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestLeftNodeEquals() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Left = new BSTNode<int>() { Data = 1, }
            };

            Assert.IsTrue(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestLeftNodeGreater() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Left = new BSTNode<int>() { Data = 2, }
            };

            Assert.IsFalse(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestLeftTreeSmaller() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Left = new BSTNode<int>() {
                    Data = 0,
                    Left = new BSTNode<int>() {

                        Data = -1,
                    }
                }
            };

            Assert.IsTrue(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestLeftTreeGreater() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Left = new BSTNode<int>() {
                    Data = 0,
                    Left = new BSTNode<int>() {

                        Data = 2,
                    }
                }
            };

            Assert.IsFalse(testData.IsBSTSatisfied());
        }




        [TestMethod]
        public void TestRightNodeSmaller() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Right = new BSTNode<int>() { Data = 0, }
            };

            Assert.IsFalse(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestRightNodeEquals() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Right = new BSTNode<int>() { Data = 1, }
            };

            Assert.IsTrue(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestRightNodeGreater() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Right = new BSTNode<int>() { Data = 2, }
            };

            Assert.IsTrue(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestRightTreeSmaller() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Right = new BSTNode<int>() {
                    Data = 1,
                    Right = new BSTNode<int>() {

                        Data = -1,
                    }
                }
            };

            Assert.IsFalse(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestRightTreeGreater() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Right = new BSTNode<int>() {
                    Data = 1,
                    Right = new BSTNode<int>() {

                        Data = 2,
                    }
                }
            };

            Assert.IsTrue(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestMaxContidion() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Left = new BSTNode<int>() {
                    Data = -10,
                    Right = new BSTNode<int>() {

                        Data = 2,
                    }
                }
            };

            Assert.IsFalse(testData.IsBSTSatisfied());
        }

        [TestMethod]
        public void TestMinContidion() {

            var testData = new BSTNode<int>() {
                Data = 1,
                Right = new BSTNode<int>() {
                    Data = 10,
                    Left = new BSTNode<int>() {

                        Data = 0,
                    }
                }
            };

            Assert.IsFalse(testData.IsBSTSatisfied());
        }
        // Should also do some tests on larger data structures to check that the recursion works fully
    }
}
