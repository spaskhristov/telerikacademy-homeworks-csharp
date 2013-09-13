using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.Test
{
    [TestClass]
    public class UnitTestCountRepeatingValues
    {
        static int min = Int32.MinValue;
        static int max = Int32.MaxValue;
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 1, min, 3, max, 3, 1, min, 3, max, 3 };
            int number = 3;
            int counter = CountRepeatingValues.CountRepeatingVal(array, number);
            Assert.AreEqual(4, counter);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 1, min, 3, max, 3 };
            int number = min;
            int counter = CountRepeatingValues.CountRepeatingVal(array, number);
            Assert.AreEqual(1, counter);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 1, min, 7, max, max, 7, max, max };
            int number = max;
            int counter = CountRepeatingValues.CountRepeatingVal(array, number);
            Assert.AreEqual(4, counter);
        }
    }
}
