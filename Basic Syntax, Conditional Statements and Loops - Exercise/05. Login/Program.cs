using System;
namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string passwordInput = Console.ReadLine();
            string password = string.Empty;
            int wrongAttempts = 0;

            for (int i = user.Length - 1; i >= 0; i--)
            {
                password += user[i];
            }

            while (passwordInput != password)
            {
                wrongAttempts++;
                if (wrongAttempts == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                passwordInput = Console.ReadLine();
            }
            if (wrongAttempts < 4)
            {
                Console.WriteLine($"User {user} logged in.");
            }
            else
            {
                Console.WriteLine($"User {user} blocked!");
            }
        }
    }
}