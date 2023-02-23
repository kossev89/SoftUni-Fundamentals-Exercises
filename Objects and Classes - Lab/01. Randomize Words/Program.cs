string[] words = Console.ReadLine().Split().ToArray();

Random Random = new Random();

for (int i = 0; i < words.Length; i++)
{
    int randomIndex = Random.Next(words.Length);
    string currentWord = words[i];
    string randomWord = words[randomIndex];
    words[i] = randomWord;
    words[randomIndex] = currentWord;
}
Console.WriteLine(string.Join(Environment.NewLine, words));