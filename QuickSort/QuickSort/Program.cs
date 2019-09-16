using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 7, 9, 2, 5, 8, 21, 8, 2, 1 };
            foreach (var item in Sort(list))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var s in Sort(new List<string> { "Zebra", "cat", "Ardvark", "dog" }))
            {
                Console.WriteLine(s);
            }
        }

        private static List<T> Sort<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null || list.Count <= 1) return list;
            var left = new List<T>();
            var right = new List<T>();
            var pivot = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                var listItem = list[i];
                var order = listItem.CompareTo(pivot);
                if (order <= 0)
                {
                    left.Add(listItem);
                }
                else
                {
                    right.Add(listItem);
                }
            }
            var sortedLeft = Sort(left);
            var sortedRight = Sort(right);

            var final = sortedLeft;
            final.Add(pivot);
            final.AddRange(sortedRight);

            return final;
        }
    }
}
