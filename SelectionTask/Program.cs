using System;

namespace SelectionTask
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Ask for persons age
            Console.WriteLine("Please enter your age!");
            int age = int.Parse(Console.ReadLine());

            // If they're greater than 17 they are of legal adult age! 
            if (age >= 17 ) {
            Console.WriteLine("You are of legal adult age!");
            } else {
            Console.WriteLine("You are not of legal adult age!"); 
            }

            // Ask for persons gender
            Console.WriteLine("What is your gender?");
            string gender = Console.ReadLine();
            Console.WriteLine("This person is " + gender + " and " + age +  " years old ");
            
            // Asking for two numbers
            Console.WriteLine("Input a number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input a second number");
            int number2 = int.Parse(Console.ReadLine()); 
            if (number1 + number2 >= 10) {
                Console.WriteLine("Sum of numbers is greater than 10");
            }
            else {
                Console.WriteLine("Sum of numbers is less than 10");
            }
            
            // Exercise 2 - Username and Password
            string username = "Qui";
            string password = "Dang";

            
            Console.WriteLine("Enter your username!");
            string inputUsername = Console.ReadLine();

            if(inputUsername == username) {
                Console.WriteLine("Enter your password!");
                string inputPassword = Console.ReadLine();
                
                 if (inputPassword == password) {
                    Console.WriteLine("Login successful!");
                } else {
                    Console.WriteLine("Login unsuccessful!");
                }

            } else {
                Console.WriteLine("Login unsuccessful!");
            }
        }
    }
} 