using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_HightAndLowest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_1_Should_Be_1()
        {
            Assert.AreEqual("1", Kata.FindHigh("1"));
        }

        [TestMethod]
        public void Input_12_Should_Be_2()
        {
            Assert.AreEqual("2", Kata.FindHigh("1 2"));
        }

    }

    public class Kata
    {
        public static string FindHigh(string s)
        {
            var sArray = s.Split(' ');
            return sArray.Max();
        }
    }
}
