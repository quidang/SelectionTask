using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing out their name 10 times.
            Console.WriteLine("Exericse 1, Task 1");
            Console.WriteLine("Please enter your first name!");
            string firstname = (Console.ReadLine());

               for (int i = 0; i < 10; i++) { 
                Console.WriteLine(firstname);
               }
            // user inputting their own number for their name to be printed.
            Console.WriteLine("Exercise 1, Task 2");
            Console.WriteLine("Enter the amount of times you want your first name to be printed");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(firstname);
            }

            string result;

            Console.WriteLine("Exercise 2, Task 1");
            for (int i = 1; i <= 5; i++) {
                result = new String('x', i);
                Console.WriteLine(result);
            }
            Console.WriteLine("Exercuse 2, Task 2");
            for (int i = 5; i >= 1; i--) {
                result = new String('x', i);
                Console.WriteLine(result);
            }
        }
    }
}