using System;
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
    struct KeyValue
    {
        public readonly string key;
        public readonly object value;
        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class MyDictionary
    {
        KeyValue[] arr1 = new KeyValue[10];
        int track = 0;

        public object this[string index]
        {
            get
            {
                foreach (var item in arr1)
                {
                    if (item.key == index)
                        return item.value;                       
                }
                throw new KeyNotFoundException($"The given key '{index}' wasn't found.");
            }
            set
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i].key == index)
                    {
                        arr1[i] = new KeyValue(index, value);
                        return;
                    }
                }
                if (track < arr1.Length)
                {
                    arr1[track++] = new KeyValue(index, value);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
