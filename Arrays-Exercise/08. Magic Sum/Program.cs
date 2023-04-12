int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int magicNumber = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        sum = array[i] + array[j];
        if (sum == magicNumber)
        {
            Console.WriteLine(array[i] + " " + array[j]);
        }
    }
}
