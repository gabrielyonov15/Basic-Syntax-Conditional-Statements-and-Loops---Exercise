﻿namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalCoins = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                double coin = double.Parse(input);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    totalCoins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "End")
                {
                    break;
                }
                double price = 0;
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }
                if (totalCoins >= price)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    totalCoins -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
