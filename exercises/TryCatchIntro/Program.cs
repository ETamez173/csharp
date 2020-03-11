using System;

namespace TryCatchIntro
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("What is the bank difficulty?");
            var userInput = Console.ReadLine();

            try
            {
                int difficulty = int.Parse(userInput);
                var taco = 100 / difficulty;

            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("That is not a valid number");
            }

            // var taco = 100 / 0;
            // Console.Writeline(100 / 0);
        }
    }
    Console.WriteLine("The difficultu is {}");
}
}