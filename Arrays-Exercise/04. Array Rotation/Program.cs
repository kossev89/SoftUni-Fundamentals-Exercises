using System.Globalization;
using System.Linq;

int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int numberOfRtoations = int.Parse(Console.ReadLine());
int[] workArray = new int[inputArray.Length];
Array.Copy(inputArray, workArray, inputArray.Length);
ArrayRorarion(numberOfRtoations);
Console.WriteLine(String.Join(' ', workArray));

void ArrayRorarion(int numberOfRtoations)
{
    for (int i = 0; i < numberOfRtoations; i++)
    {
        for (int j = 0; j < inputArray.Length - 1; j++)
        {
            if (j == 0)
            {
                workArray[workArray.Length - 1] = inputArray[0];
                workArray[j] = inputArray[j + 1];
            }
            else
            {
                workArray[j] = inputArray[j + 1];
            }
        }
        Array.Copy(workArray, inputArray, workArray.Length);
    }
}