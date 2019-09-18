using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 1;
            int buzz = 1;
            int fb = 1;
            for (int i = 1; i < 25; i++)
            {
                if (fb >= 15)
                {
                    Console.WriteLine("FizzBuzz");
                    fb = 1;
                    fizz=1;
                    buzz=1;
                    continue;
                }
                if (fizz>=3)
                {
                    Console.WriteLine("Fizz");
                    fizz = 1;
                    buzz++;
                    fb++;
                    continue;
                }
                if (buzz >= 5)
                {
                    Console.WriteLine("Buzz");
                    buzz = 1;
                    fizz++;
                    fb++;
                    continue;
                }
                
                fizz++;
                buzz++;
                fb++;
                Console.WriteLine(i);
            }
        }
    }

}
