int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < inputArray.Length; i++)
{
    bool isTop = true;
    for (int j = i + 1; j < inputArray.Length; j++)
    {
        if (inputArray[i] <= inputArray[j])
        {
            isTop = false;
            break;
        }
    }
    if (isTop)
    {
        Console.Write(inputArray[i] + " ");
    }
}
