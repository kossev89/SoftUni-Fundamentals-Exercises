string[] firstArray = Console.ReadLine().Split();
string[] secondArray = Console.ReadLine().Split();

for (int i = 0; i < secondArray.Length; i++) // 1 2 5 5    // a 2 s 5
{
    for (int j = 0; j < firstArray.Length; j++)
    {
        if (secondArray[i] == firstArray[j])
        {
            Console.Write(secondArray[i] + " ");
        }
    }
}