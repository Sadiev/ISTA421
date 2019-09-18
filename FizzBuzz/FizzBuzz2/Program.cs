using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(21);
        }
        private static void FizzBuzz(int v)
        {
            for (int i = 1; i <= v; i++)
            {
                string s = "";

                s += i.IfDivisibleBy(3, "Fizz");
                s += i.IfDivisibleBy(5, "Buzz");
                s += i.IfDivisibleBy(7, "Woz");
                s += i.IfDivisibleBy(13, "Zow");

                if (String.IsNullOrEmpty(s))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
    public static class Util
    {
        public static string IfDivisibleBy(this int i, int m, string s)
        {
            if (i % m == 0)
            {
                return s;
            }
            else
            {
                return "";
            }
        }
    }
}
