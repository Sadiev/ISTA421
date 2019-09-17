using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    interface IMonoid<T>
    {
        T Mempty { get; }
        T Mappend(T first, T second);
    }

    class IntegerAddition : IMonoid<int>
    {
        public int Mempty => 0;

        public int Mappend(int first, int second) => first + second;
    }

    class IntegerMultiplication : IMonoid<int>
    {
        public int Mempty => 1;

        public int Mappend(int first, int second) => first * second;
    }

    class StringMonoid : IMonoid<string>
    {
        public string Mempty => "";

        public string Mappend(string first, string second) => first + second;
    }

    class Program
    {
        static T Id<T>(T t) => t;

        static T Mconcat<Monoid, T>(Monoid m, List<T> list) where Monoid : IMonoid<T>
        {
            T accum = m.Mempty;

            foreach (var v in list)
            {
                accum = m.Mappend(accum, v);
            }

            return accum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".Select(Id));

            var ints = Enumerable.Range(1, 10).ToList();

            Console.WriteLine(Mconcat(new IntegerAddition(), ints));
            Console.WriteLine(Mconcat(new IntegerMultiplication(), ints));
            Console.WriteLine(Mconcat(new StringMonoid(),
                                          ints.Select(i => i.ToString()).ToList()));
        }
    }
}