using System;
using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"(\@|\#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
Regex regex = new Regex(pattern);
MatchCollection MatchCollection = regex.Matches(input);
Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

if (MatchCollection.Count == 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{MatchCollection.Count} word pairs found!");
}

foreach (Match item in MatchCollection)
{
    string firstWord = item.Groups["first"].Value.ToString();
    char[] secondWord = item.Groups["second"].Value.ToCharArray();
    Array.Reverse(secondWord);
    string secondWordReversed = new string(secondWord);

    if (firstWord == secondWordReversed.ToString())
    {
        mirrorWords[firstWord] = item.Groups["second"].Value.ToString();
    }
    else
    {
        continue;
    }
}
List<StringBuilder> output = new List<StringBuilder>();
if (mirrorWords.Count > 0)
{
    Console.WriteLine("The mirror words are:"); //Part <=> traP, leveL <=> Level, sAw <=> wAs
    foreach (var word in mirrorWords)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"{word.Key} <=> {word.Value}");
        output.Add(stringBuilder);
    }
    Console.WriteLine(String.Join(", ", output));
}
else
{
    Console.WriteLine("No mirror words!");
}
