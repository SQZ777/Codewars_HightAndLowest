using System;
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
            Assert.AreEqual("1", Kata.FindLow("1 2"));
        }

        [TestMethod]
        public void Input_123_Should_Be_31()
        {
            Assert.AreEqual("3 1", Kata.HighAndLow("1 2 3"));
        }

        [TestMethod]
        public void Input_1f23_Should_Be_3f2()
        {
            Assert.AreEqual("3 -2", Kata.HighAndLow("1 -2 3"));
        }

        [TestMethod]
        public void Input_f1f2f3_Should_Be_f1f3()
        {
            Assert.AreEqual("-1 -3",Kata.HighAndLow("-1 -2 -3"));
        }

    }

    public class Kata
    {
        public static string FindHigh(string s)
        {
            return Array.ConvertAll(s.Split(), Convert.ToInt32).Max().ToString();
        }

        public static string FindLow(string s)
        {
            return Array.ConvertAll(s.Split(), Convert.ToInt32).Min().ToString();
        }
        public static string HighAndLow(string s)
        {
            return FindHigh(s) + " " + FindLow(s);
        }
    }
}
