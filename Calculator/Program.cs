using System;

namespace MyCalculator
{
    class Program
    {
        public string? name;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to my first Project!");

            while (true)
            {
                Console.Write("\nPlease enter your first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The first number you chose is: " + firstNumber);

                Console.Write("Please enter your second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The second number you chose is: " + secondNumber);

                Console.Write("Please enter your operation type (+, -, *, /): ");
                string typeOfOperation = Console.ReadLine()!;
                Console.WriteLine("The operation you chose is: " + typeOfOperation);

                Testing.Operation(firstNumber, secondNumber, typeOfOperation);


                Console.Write("\nDo you want to perform another calculation? (y/n): ");
                string answer = Console.ReadLine()!.ToLower();

                if (answer == "n" || answer == "no")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
