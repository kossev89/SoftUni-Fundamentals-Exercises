string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double totalSum = 0;

foreach (var item in input)
{
    string numberToString = string.Empty;
    double currentSum = 0;
    char[] argArray = item.ToCharArray();
    char firstOperation = argArray[0];
    char secondOperation = argArray[argArray.Length - 1];

    foreach (var c in argArray)
    {
        if (Char.IsDigit(c))
        {
            numberToString += c;
        }
    }

    double number = double.Parse(numberToString);
    if (Char.IsUpper(firstOperation))
    {
        currentSum += number / (firstOperation - 64);
    }
    else if (Char.IsLower(firstOperation))
    {
        currentSum += number * (firstOperation - 96);
    }

    if (Char.IsUpper(secondOperation))
    {
        currentSum -= secondOperation - 64;
    }
    else if (Char.IsLower(secondOperation))
    {
        currentSum += secondOperation - 96;
    }
    totalSum += currentSum;
}
Console.WriteLine($"{totalSum:f2}");