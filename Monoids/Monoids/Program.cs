using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static T Id<T>(T t) => t;

        static T Mconcat<T>(IEnumerable<T> list) where T : IMonoid<T>
        {
            if (list == null || !list.Any()) return default;
             
            T accum = list.First().Mempty;

            foreach (var v in list)
            {
                accum = accum.Mappend(v);
            }

            return accum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new String("Hello World!".Select(Id).ToArray()));

            var ints = Enumerable.Range(1, 10);

            Console.WriteLine(
                Mconcat(
                    ints.Select(IntegerAddition.Pack))
                .Value);

            Console.WriteLine(
                Mconcat(
                    ints.Select(IntegerMultiplication.Pack))
                .Value);

            Console.WriteLine(
                Mconcat(
                    ints.Select(i => StringMonoid.Pack(i.ToString())))
                .Value);

            FizzBuzz(21);
        }

        private static void FizzBuzz(int v)
        {
            for (int i = 1; i <= v; ++i)
            {
                var s = 
                    Mconcat(new[]//new List<Maybe<StringMonoid>>
                                { i.IfDivisibleBy(3, "Fizz")
                                , i.IfDivisibleBy(5, "Buzz")
                                , i.IfDivisibleBy(7, "Woz")})
                      .FromMaybe(StringMonoid.Pack(i.ToString()))
                      .Value;

                Console.WriteLine(s);
            }
        }
    }

    static class Util
    {
        static public Maybe<StringMonoid> IfDivisibleBy(this int i,
                                                        int modulus,
                                                        string s)
        {
            if (i % modulus == 0)
            {
                return Maybe<StringMonoid>.Just(StringMonoid.Pack(s));
            }
            else
            {
                return Maybe<StringMonoid>.Nothing;
            }
        }
    }
}
