using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersDivisibleByThree = 0;

            for (int i = 1; i <= 100 ; i++)
            {
                if (i % 3 == 0)
                {
                    numbersDivisibleByThree += 1 ;
                }
            }
            Console.WriteLine($"{numbersDivisibleByThree}");

            Console.WriteLine($"enter a number or OK to exit");
            string breakCommand = "OK";
            int numberSum = 0;
            string userEntry = Console.ReadLine();

            while (userEntry != breakCommand.ToUpper())
            {
                int userNumber = Convert.ToInt32(userEntry);
                numberSum += userNumber;
                Console.WriteLine($"enter a number or OK to exit");
            }
            Console.WriteLine($"Total sum = {numberSum}");






        }
    }
}
