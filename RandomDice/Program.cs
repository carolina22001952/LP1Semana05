using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n;
            int sum = 0;

            Random random = new Random();

            // Write instruction
            Console.WriteLine("How many dice you want to role?");

            // Get number o dice
            n = int.Parse(Console.ReadLine());


            // Show the number of each dice
            for(int i = 0; i < n; i++)
            {
                int value = random.Next(1,7);
                Console.WriteLine($"Dice number {i} = {value}");
                sum += value;
            }

            // Show sum of all dice
            Console.WriteLine($"Sum of all dice = {sum}.");
        }
    }
}
