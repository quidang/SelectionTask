using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            // printing out their name 10 times.
            // Console.WriteLine("Please enter your first name!");
            // string name = (Console.ReadLine());

            //    for (int i = 0; i < 10; i++) { 
            //     Console.WriteLine(name);
            //   }
            // user inputting their own number for their name to be printed.
            Console.WriteLine("Please enter your first name!");
            string name = (Console.ReadLine());

            Console.WriteLine("Enter the amount of times you want your first name to be printed"); 
            int number = int.Parse(Console.ReadLine());
                    
                for (int i = 0; i < number; i++) {
                    Console.WriteLine(name);
                }
                    
        }
    }   
}