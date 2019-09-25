using System;
using System.Collections.Generic;

namespace GenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            List<int> list = new List<int>() {1,2,3,4,5 };
            Console.WriteLine("---============= List<int> ================---");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("---============= LinkedList ================---");
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(1);
            ll.AddFirst(2);
            ll.AddFirst(3);
            ll.AddFirst(4);
            ll.AddFirst(5);
            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("---============= Queue ================---");
            Queue<int> queue = new Queue<int>();
            foreach (var item in new int[5] {1,2,3,4,5 })
            {
                queue.Enqueue(item);
            }
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("---============= Stack ================---");
            Stack<int> stack = new Stack<int>();
            foreach (var item in new int[5] { 1, 2, 3, 4, 5 })
            {
                stack.Push(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("---============= Dictionary ================---");
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var item in new int[5] { 1, 2, 3, 4, 5 })
            {
                dic[item]= rand.Next(1, 100);
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"dic[{item.Key}]={item.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("---============= HashSet ================---");
            HashSet<string> hashSet = new HashSet<string>();
            foreach (var item in new string[5] { "dog", "cat", "mouse", "lion", "tiger" })
            {
                hashSet.Add(item);
            }
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("---============= SortedList ================---");
            SortedList<string, int> sortedList = new SortedList<string, int>();
            foreach (var item in new string[5] { "dog", "cat", "mouse", "lion", "tiger" })
            {
                sortedList.Add(item,rand.Next(1,100));
            }
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
