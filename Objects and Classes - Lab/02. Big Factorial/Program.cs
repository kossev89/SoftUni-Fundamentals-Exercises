using System.Numerics;

int inputNumber = int.Parse(Console.ReadLine());

BigInteger factorial = 1;
for (int i = 2; i <= inputNumber; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);