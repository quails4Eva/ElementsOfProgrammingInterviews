using System;
using _7._1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void Test7_1_StringToInt() {

            Assert.AreEqual(100, Problem7_1.StringToInt("100"));
            Assert.AreEqual(134, Problem7_1.StringToInt("134"));
            Assert.AreEqual(982, Problem7_1.StringToInt("982"));
            Assert.AreEqual(43890453, Problem7_1.StringToInt("43890453"));
        }

        [TestMethod]
        public void Test7_1_StringToIntNegative() {

            // Negative
            Assert.AreEqual(-43489, Problem7_1.StringToInt("-43489"));
        }

        [TestMethod]
        public void Test7_1_StringToInt0() {
            
            Assert.AreEqual(-0, Problem7_1.StringToInt("-0"));
            Assert.AreEqual(0, Problem7_1.StringToInt("0"));
        }

        [TestMethod]
        public void Test7_1_IntToString() {

            Assert.AreEqual("100", Problem7_1.IntToString(100));
            Assert.AreEqual("134", Problem7_1.IntToString(134));
            Assert.AreEqual("982", Problem7_1.IntToString(982));
            Assert.AreEqual("43890453", Problem7_1.IntToString(43890453));
        }

        [TestMethod]
        public void Test7_1_IntToStringNegative() {

            // Negative
            Assert.AreEqual("-43489", Problem7_1.IntToString(-43489));
        }

        [TestMethod]
        public void Test7_1_IntToString0() {
            
            Assert.AreEqual("0", Problem7_1.IntToString(-0));
            Assert.AreEqual("0", Problem7_1.IntToString(0));
        }
    }
}
