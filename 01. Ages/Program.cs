using System;
namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the age:");
            string command = Console.ReadLine();

            while (command != "End")
            {
                bool input = int.TryParse(command, out int age);
                if (age < 0 || age >= 130 || input == false)
                {
                    Console.WriteLine("Wrong input! The age should be a number between 0 and 130 years!");
                    Console.WriteLine("Please, try again!");
                    command = Console.ReadLine();
                }
                else
                {
                    string output = "";
                    if (age <= 2)
                    {
                        output = "baby";
                    }
                    else if (age <= 13)
                    {
                        output = "child";
                    }
                    else if (age <= 19)
                    {
                        output = "teenager";
                    }
                    else if (age <= 65)
                    {
                        output = "adult";
                    }
                    else
                    {
                        output = "elder";
                    }
                    Console.WriteLine($"The person is {output}");
                    Console.WriteLine("Enter new age, or enter End to exit the program!");
                    command = Console.ReadLine();
                }
            }
        }
    }
}