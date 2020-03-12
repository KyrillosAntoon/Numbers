// Kyrillos "Chris" Antoon
// Numbers Problem from C# 2561
// 09/28/2018

using Opeartions;
using System;

namespace NumbersProblem
{
    class Program
    {
        private static void Main(string[] args)
        {
            double first = 0, second = 0, third = 0, greatest = 0, smallest = 0;     // Variables to store user input & results
            bool quit = false;                                                       // Checks if user quit

            do
            {

                try
                {
                    Console.WriteLine("Please enter three " +
                        "numbers below (0 for all to quit).");                      // Instruct user then take input

                    Console.Write("Please enter the first number: ");               // Prompt and read in value 1
                    first = System.Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter the second number: ");              // Prompt and read in value 2
                    second = System.Convert.ToDouble(Console.ReadLine());

                    Console.Write("Please enter the third number: ");               // Prompt and read in value 3
                    third = System.Convert.ToDouble(Console.ReadLine());

                    if (first != 0 && second != 0 && third != 0)                    // Check if user quit
                    {
                        Console.WriteLine("\n\n\n");                                // Formatting

                        Console.WriteLine("The sum of the numbers are: "            // Print out the sum
                            + OperationsClass.Sum(first, second, third).ToString()
                            + " \n\n");

                        Console.WriteLine("The product of the numbers are: " +      // Print out the product
                            OperationsClass.Product(first, second, third).ToString()
                            + " \n\n");

                        Console.WriteLine("The Average of the numbers are: " +      // Print out the average
                            OperationsClass.Average(first, second, third).ToString()
                            + " \n\n");

                        OperationsClass.Compare(first, second, third, ref greatest, ref smallest); // Call the Compare method to determine the greatest and smallest

                        Console.WriteLine("The greatest number is: "                // Print out the greatest number
                            + greatest + "\n ");

                        Console.WriteLine("The smallest number is: "                // Print out the smallest number
                            + smallest + "\n ");
                    }
                    else
                    {
                        quit = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                }
            } while (!quit);                  // Check if user did not quit

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}