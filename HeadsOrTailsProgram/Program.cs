using System;
using System.ComponentModel.DataAnnotations;
using static HeadsOrTailsLibrary.HeadsOrTails;

namespace HeadsOrTailsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task #01. Heads and tails\n");
            Console.Write("Enter number of coin tosses: ");

            try
            {
                int numberThrow = int.Parse(Console.ReadLine());
                int head = CalculateDropOneSide(numberThrow);
                Console.WriteLine("\nHead: " + head);
                Console.WriteLine("Tail: " + (numberThrow-head));
            }
            catch (ValidationException)
            {
                Console.WriteLine("\nError: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: FormatException");
            }
        }
    }
}