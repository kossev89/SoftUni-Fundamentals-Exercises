Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
int numberOfWords = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfWords; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();
    if (!words.ContainsKey(word))
    {
        words.Add(word, new List<string>());
        words[word].Add(synonym);
    }
    else
    {
        words[word].Add(synonym);
    }
}

foreach (var word in words)
{
    Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
}

