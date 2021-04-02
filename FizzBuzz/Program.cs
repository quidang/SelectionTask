using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(17 % 5);
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine(String.Format("FizzBuzz: {0}", i));
                }
                else if (i % 3 == 0) {
                    Console.WriteLine(String.Format("Fizz: {0}", i));    
                }
                else if (i % 5 == 0) {
                    Console.WriteLine(String.Format("Buzz: {0}", i));
                }
            }
        }
    }
}