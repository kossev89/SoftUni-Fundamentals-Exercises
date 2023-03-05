int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

for (int i = 0; i < input.Length; i++)
{
    if (!numbers.ContainsKey(input[i]))
    {
        numbers.Add(input[i], 1);
    }
    else
    {
        numbers[input[i]]++;
    }
}

foreach (var number in numbers)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}