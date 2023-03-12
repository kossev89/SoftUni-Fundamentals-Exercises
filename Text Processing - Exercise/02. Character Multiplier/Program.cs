
//Peter George


string[] input = Console.ReadLine().Split();
int totalSum = MultiplyChars(input[0], input[1]);
Console.WriteLine(totalSum);


static int MultiplyChars(string firstInput, string secondInput)
{
    int totalSum = 0;
    if (firstInput.Length > secondInput.Length)
    {
        for (int i = 0; i < secondInput.Length; i++)
        {
            totalSum += firstInput[i] * secondInput[i];
        }
        int difference = firstInput.Length - secondInput.Length;
        char[] lastChars = firstInput.TakeLast(difference).ToArray();
        foreach (var item in lastChars)
        {
            totalSum += item;
        }
    }
    else if (secondInput.Length > firstInput.Length)
    {
        for (int i = 0; i < firstInput.Length; i++)
        {
            totalSum += secondInput[i] * firstInput[i];
        }
        int difference = secondInput.Length - firstInput.Length;
        char[] lastChars = secondInput.TakeLast(difference).ToArray();
        foreach (var item in lastChars)
        {
            totalSum += item;
        }
    }
    else
    {
        for (int i = 0; i < firstInput.Length; i++)
        {
            totalSum += secondInput[i] * firstInput[i];
        }
    }
    return totalSum;
}

