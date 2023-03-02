using System;

namespace Marcet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "juice")
                {
                    double price = 1.20;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "coffee")
                {
                    double price = 0.50;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "water")
                {
                    double price = 0.80;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "sweets")
                {
                    double price = 1.45;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "peanuts")
                {
                    double price = 1.60;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (town == "Plovdiv")
            {
                if (product == "juice")
                {
                    double price = 1.15;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "coffee")
                {
                    double price = 0.40;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "water")
                {
                    double price = 0.70;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "sweets")
                {
                    double price = 1.30;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "peanuts")
                {
                    double price = 1.50;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (town == "Varna")
            {
                if (product == "juice")
                {
                    double price = 1.10;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "coffee")
                {
                    double price = 0.45;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "water")
                {
                    double price = 0.70;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "sweets")
                {
                    double price = 1.35;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }

                if (product == "peanuts")
                {
                    double price = 1.55;
                    double newPrice = price * number;
                    Console.WriteLine(newPrice);
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}