using System;
using System.Collections.Generic;
using System.Linq;


namespace StackProject
{
    class Stack<StackValue>
    {
        private List<StackValue> list = new List<StackValue>();

        public IEnumerable<StackValue> Data => Enumerable.Reverse(list);

        public int Count { get => list.Count; }

        public StackValue this[int offset]
        {
            get => list[(list.Count - 1) - offset];
        }

        public void Push(StackValue i)
        {
            list.Add(i);
        }

        public StackValue Pop()
        {
            var lastIndex = list.Count - 1;
            var tmp = list[lastIndex];

            list.RemoveAt(lastIndex);

            return tmp;
        }

        public StackValue Peek() => list[list.Count - 1];
    }


    class Program
    {
        static void Main(string[] args)
        {
            UseStackWhithInt();
            UseStackWhithString();
        }

        private static void UseStackWhithString()
        {
            var s = new Stack<string>();

            s.Push("Cat");
            s.Push("Cat");


            Console.WriteLine();

            while(s.Count>0)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine($"\n{s.Count}");
        }

        private static void UseStackWhithInt()
        {
            var s = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                s.Push(i + 1);
            }

            foreach (var i in s.Data)
            {
                Console.WriteLine($"Enumerable: {i}");
            }

            var count = s.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine($"\n{s.Count}");
        }
    }
}
