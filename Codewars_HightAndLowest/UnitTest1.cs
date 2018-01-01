using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_HightAndLowest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindHigh_Input_1_Should_Be_1()
        {
            Assert.AreEqual("1", Kata.FindHigh("1"));
        }

        [TestMethod]
        public void FindHigh_Input_12_Should_Be_2()
        {
            Assert.AreEqual("2", Kata.FindHigh("1 2"));
        }

        [TestMethod]
        public void FindLowest_Input_12_Should_Be_1()
        {
            Assert.AreEqual("1",Kata.FindLow("1 2"));
        }

    }

    public class Kata
    {
        public static string FindHigh(string s)
        {
            return s.Split(' ').Max();
        }

        public static string FindLow(string s)
        {
            return s.Split().Min();
        }
    }
}
