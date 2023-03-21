using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

string[] participants = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
Dictionary<string, double> result = new Dictionary<string, double>();

foreach (var name in participants)
{
    result.Add(name, 0);
}

Regex Regex = new Regex(@"(?<name>[A-Za-z]*)(?<digits>[0-9]*)");
Match match = Regex.Match(result.ToString());
string input = Console.ReadLine();

while (input != "end of race")
{
    if (match.Success)
    {
        MatchCollection names = Regex.Matches(input, @"(?<name>[A-Za-z]*)");
        string name = string.Join(string.Empty, names);
        if (result.ContainsKey(name))
        {
            MatchCollection digits = Regex.Matches(input, @"(?<digits>[0-9]*)");
            char[] allDigits = string.Join(string.Empty, digits).ToCharArray();
            double distance = 0;
            foreach (var digit in allDigits)
            {
                distance += Char.GetNumericValue(digit);
            }
            result[name] += distance;
        }
    }
    input = Console.ReadLine();
}
var outputResult =result.OrderByDescending(x => x.Value);
List<string> winners = new List<string>();
foreach (var item in outputResult)
{
    winners.Add(item.Key);
}
string firstRacer = winners[0];
string secondRacer = winners[1];
string thirdRacer = winners[2];

Console.WriteLine($"1st place: {firstRacer}");
Console.WriteLine($"2nd place: {secondRacer}");
Console.WriteLine($"3rd place: {thirdRacer}");
