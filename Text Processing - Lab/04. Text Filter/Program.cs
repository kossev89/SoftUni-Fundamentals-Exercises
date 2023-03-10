string[] bannedWords = Console.ReadLine().Split(", ");
string input = Console.ReadLine();
string output = input;

foreach (var word in bannedWords)
{
    string replacement = new string('*', word.Length);
    output = output.Replace(word, replacement);
}
Console.WriteLine(output);