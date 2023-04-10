using System.Drawing;
using System.Text.RegularExpressions;

string pattern = @"(\@|\#)+(?<color>\b[a-z]{3,}\b)(\@|\#)+([^a-zA-Z0-9]+)?(\/+)(?<amount>\d+)(\/+)";
Regex regex = new Regex(pattern);
string input = Console.ReadLine();
MatchCollection MatchCollection = regex.Matches(input);

foreach (Match item in MatchCollection)
{
    string amount = item.Groups["amount"].Value.ToString();
    string color = item.Groups["color"].Value.ToString();
    Console.WriteLine($"You found {amount} {color} eggs!");
}