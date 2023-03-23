using System.Text;
using System.Text.RegularExpressions;

string pattern = @"(\=|\/)(?<place>[A-Z][A-z]{2,})\1";
Regex regex = new Regex(pattern);
string input = Console.ReadLine();
int travelPoints = 0;
MatchCollection validPlaces = regex.Matches(input);
List<string> destinations = new List<string>();
foreach (Match match in validPlaces)
{
    travelPoints += match.Groups["place"].Value.Length;
    destinations.Add(match.Groups["place"].Value);

}
Console.WriteLine($"Destinations: {String.Join(", ", destinations)}");
Console.WriteLine($"Travel Points: {travelPoints}");
