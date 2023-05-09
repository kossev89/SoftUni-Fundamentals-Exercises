using System.Linq;

int numberOfInputs = int.Parse(Console.ReadLine());
int[] outputArray = new int[numberOfInputs];
for (int i = 0; i < numberOfInputs; i++)
{
    int sum = 0;
    char[] input = Console.ReadLine().ToArray();
    foreach (char item in input)
    {
        if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' || item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
        {
            sum += item * input.Length;
        }
        else
        {
            sum += item / input.Length;
        }
    }
    outputArray[i] = sum;
}
Array.Sort(outputArray);
for (int i = 0; i < outputArray.Length; i++)
{
    Console.WriteLine(outputArray[i]);
}