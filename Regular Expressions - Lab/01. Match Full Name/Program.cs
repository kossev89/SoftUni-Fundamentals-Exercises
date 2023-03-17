using System.Text.RegularExpressions;

string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
string input = Console.ReadLine();

MatchCollection matchedNames = Regex.Matches(input, regex);

foreach (Match match in matchedNames)
{
    Console.Write($"{match} ");
}
