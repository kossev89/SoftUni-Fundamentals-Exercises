string input = Console.ReadLine();
Dictionary<char, int> characters = new Dictionary<char, int>();

foreach (char c in input.Where(x => x != ' '))
{
    if (!characters.ContainsKey(c))
    {
        characters[c] = 0;
    }
    characters[c]++;
}

foreach (var character in characters)
{
    Console.WriteLine($"{character.Key} -> {character.Value}");
}
