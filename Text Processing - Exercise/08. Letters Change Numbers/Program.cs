string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double totalSum = 0;

foreach (var item in input)
{
    char firstOperation = item[0];
    char secondOperation = item[item.Length - 1];
    double number = double.Parse(item.Substring(1, item.Length - 2));
    double currentSum = 0;

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