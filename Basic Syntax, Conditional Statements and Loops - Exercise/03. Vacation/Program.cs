using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal priceForPerson = 0;
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            priceForPerson = 8.45M; break;
                        case "Saturday":
                            priceForPerson = 9.80M; break;
                        case "Sunday":
                            priceForPerson = 10.46M; break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            priceForPerson = 10.90M; break;
                        case "Saturday":
                            priceForPerson = 15.60M; break;
                        case "Sunday":
                            priceForPerson = 16.00M; break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            priceForPerson = 15.00M; break;
                        case "Saturday":
                            priceForPerson = 20.00M; break;
                        case "Sunday":
                            priceForPerson = 22.50M; break;
                    }
                    break;
            }
            decimal totalPrice = priceForPerson * peopleCount;
            if (type == "Students" && peopleCount >= 30)
            {
                totalPrice *= 0.85m;
            }
            else if (type == "Business" && peopleCount >= 100)
            {
                totalPrice -= 10 * priceForPerson;
            }
            else if (type == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                totalPrice *= 0.95m;
            }
            Console.Write($"Total price: {totalPrice:f2}");
        }
    }
}