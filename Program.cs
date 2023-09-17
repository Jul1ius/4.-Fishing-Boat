using System;

namespace _4._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishCount = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring": price = 3000; break;
                case "Summer":
                case "Autumn": price = 4200; break;
                case "Winter": price = 2600; break;                
            }
                
            if (fishCount <= 6)
            {
                price = price * 0.9;
            }
            else if (fishCount >= 7 && fishCount <= 11)
            {
                price = price * 0.85;
            }
            else if (fishCount >= 12)
            {
                price = price * 0.75;
            }
            if (fishCount % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }

            if (price > budget)
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):F2} leva.");
            }
            else
                Console.WriteLine($"Yes! You have {(budget - price):F2} leva left.");
        }
    } 
}
