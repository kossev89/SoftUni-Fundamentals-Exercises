using System;
namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "Start")
            {
                double coins = Double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1.0 || coins == 2.0)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                bool isInvalid = false;
                double price = 0;
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;
                        sum -= price;
                        break;
                    case "Water":
                        price = 0.7;
                        sum -= price;
                        break;
                    case "Crisps":
                        price = 1.5;
                        sum -= price;
                        break;
                    case "Soda":
                        price = 0.8;
                        sum -= price;
                        break;
                    case "Coke":
                        price = 1.0;
                        sum -= price;
                        break;
                    default:
                        isInvalid = true;
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sum >= 0 && isInvalid == false)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (sum < 0 && isInvalid == false)
                {
                    Console.WriteLine("Sorry, not enough money");
                    sum += price;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}