using System.Collections.Generic;
using System.Linq;
using _8._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class Test8_1 {

        private ListNode<int> List1 = new ListNode<int>() {
            Data = 0,
            Next = new ListNode<int>() {
                Data = 2,
                Next = new ListNode<int>() {
                    Data = 8,
                    Next = new ListNode<int>() {
                        Data = 24,
                        Next = null,
                    }
                }
            }
        };

        private ListNode<int> List2 = new ListNode<int>() {
            Data = 1,
            Next = new ListNode<int>() {
                Data = 2,
                Next = new ListNode<int>() {
                    Data = 3,
                    Next = new ListNode<int>() {
                        Data = 5,
                        Next = new ListNode<int>() {
                            Data = 7,
                            Next = new ListNode<int>() {
                                Data = 11,
                                Next = new ListNode<int>() {
                                    Data = 13,
                                    Next = null,
                                }
                            }
                        }
                    }
                }
            }
        };

        private ListNode<int> List3 = new ListNode<int>() {
            Data = -10,
            Next = new ListNode<int>() {
                Data = -2,
                Next = new ListNode<int>() {
                    Data = -1,
                    Next = new ListNode<int>() {
                        Data = 0,
                        Next = new ListNode<int>() {
                            Data = 0,
                            Next = new ListNode<int>() {
                                Data = 11,
                                Next = new ListNode<int>() {
                                    Data = 100,
                                    Next = null,
                                }
                            }
                        }
                    }
                }
            }
        };

        private ListNode<int> EmptyList = null;

        private ListNode<int> ShortList = new ListNode<int> {
            Data = 20,
            Next = null,
        };

        [TestMethod]
        public void Test8_1_NormalLists() {

            var expectedResult = new[] { 0, 1, 2, 2, 3, 5, 7, 8, 11, 13, 24 };

            var result = Problem8_1.MergeTwoSortedLists(List1, List2);

            TestAreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test8_1_Negatives() {

            var expectedResult = new[] { -10, -2, -1, 0, 0, 0, 2, 8, 11, 24, 100, };

            var result = Problem8_1.MergeTwoSortedLists(List1, List3);

            TestAreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test8_1_EmptyList() {

            var result = Problem8_1.MergeTwoSortedLists(List1, EmptyList);

            TestAreEqual(List1, result);
        }

        [TestMethod]
        public void Test8_1_ShortList() {

            var expectedResult = new[] { 1, 2, 3, 5, 7, 11, 13, 20 };

            var result = Problem8_1.MergeTwoSortedLists(ShortList, List2);

            TestAreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test8_1_BothEmpty() {

            var result = Problem8_1.MergeTwoSortedLists(EmptyList, EmptyList);

            TestAreEqual(null, result);
        }

        private static void TestAreEqual(IEnumerable<int> expected, ListNode<int> actual) {

            if ((expected ?? actual) == null) {

                return;
            }

            expected
                .Zip(actual, (a, b) => new[] { a, b })
                .ToList()
                .ForEach(arr => Assert.AreEqual(arr[0], arr[1], $"Expected {arr[0]}, got {arr[1]}"));
        }
    }
}
