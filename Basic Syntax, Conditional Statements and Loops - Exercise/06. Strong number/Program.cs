using System;
namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool isStrong = false;
            int sum = 0;

            string currentNumber = input.ToString();
            for (int i = 0; i < currentNumber.Length; i++)
            {
                char c = currentNumber[i];
                int currentDigit = (int)Char.GetNumericValue(c);
                int calc = currentDigit;
                for (int j = currentDigit - 1; j > 1; j--)
                {
                    calc *= j;
                }
                sum += calc;
            }
            if (sum == input)
            {
                isStrong = true;
            }
            if (isStrong)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}