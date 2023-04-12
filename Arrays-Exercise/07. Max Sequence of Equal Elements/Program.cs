int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); //2 1 1 2 3 3 2 2 2 1

int longestSequence = 0;
int startIndex = 0;
for (int i = 1; i < array.Length; i++)
{
    int currentSequence = 1;
    int currentStartIndex = i - 1;
    while (i < array.Length && array[i] == array[i - 1])
    {
        currentSequence++;
        i++;
    }
    if (currentSequence > longestSequence)
    {
        longestSequence = currentSequence;
        startIndex = currentStartIndex;
    }
}
int[] output = new int[] { };
output = array.Skip(startIndex).Take(longestSequence).ToArray();
Console.WriteLine(String.Join(" ", output));
