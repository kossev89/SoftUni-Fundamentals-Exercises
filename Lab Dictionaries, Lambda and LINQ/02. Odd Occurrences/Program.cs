string[] input = Console.ReadLine()
    .Split()
    .ToArray();
string[] inputToLower = input.Select(x => x.ToLower()).ToArray();
Dictionary<string, int> words = new Dictionary<string, int>();

for (int i = 0; i < inputToLower.Length; i++)
{
    if (!words.ContainsKey(inputToLower[i]))
    {
        words.Add(inputToLower[i], 1);
    }
    else
    {
        words[inputToLower[i]]++;
    }
}
foreach (var word in words)
{
    if (word.Value % 2 != 0)
    {
        Console.Write($"{word.Key} ");
    }
}