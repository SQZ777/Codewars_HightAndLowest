using System;
using System.Linq;

namespace Codewars_HightAndLowest
{
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