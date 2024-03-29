﻿using System;
using System.Collections.Generic;

namespace KeyValueStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
    struct KeyValue<T>
    {
        public readonly string key;
        public readonly T value;
        public KeyValue(string key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class MyDictionary
    {
        KeyValue<int>[] arr = new KeyValue<int>[5];
        int track = 0;

        public object this[string index]
        {
            get
            {
                foreach (var item in arr)
                {
                    if (item.key == index)
                        return item.value;                       
                }
                throw new KeyNotFoundException($"The given key '{index}' wasn't found.");
            }
            set
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].key == index)
                    {
                        arr[i] = new KeyValue(index, value);
                        return;
                    }
                }
                if (track < arr.Length)
                {
                    arr[track++] = new KeyValue(index, value);
                }
                else
                {
                    Console.WriteLine("Error: Cannot store more than 5 objects");
                }
            }
        }
    }
}
