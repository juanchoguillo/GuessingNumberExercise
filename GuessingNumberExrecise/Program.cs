using System;

namespace GuessingNumberExrecise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 2);

            Console.WriteLine("Try to Core");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine("Correct, Loocky Guess");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("IS to High!");
            }

            else
            {
                Console.WriteLine("Is to low!");
            }

        }
            
        }
    }

