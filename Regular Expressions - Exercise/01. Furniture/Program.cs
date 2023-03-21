using System.Text;
using System.Text.RegularExpressions;

var regex = @">{2}(?<furniture>[A-Z]{1}\w+)<{2}(?<price>\d+(?:\.[0-9]*)?)!(?<quantity>\d*)";
string input = Console.ReadLine();
List<Match> matches = new List<Match>();
while (input != "Purchase")
{
    if (Regex.IsMatch(input, regex))
    {
        matches.Add(Regex.Match(input, regex));
    }
    input = Console.ReadLine();
}
Console.WriteLine("Bought furniture:");
decimal totalSum = 0;
foreach (Match item in matches)
{
    string furnitureName = item.Groups["furniture"].Value;
    decimal price = decimal.Parse(item.Groups["price"].Value);
    int quantity = int.Parse(item.Groups["quantity"].Value);
    totalSum += price * quantity;
    Console.WriteLine($"{furnitureName}");
}
Console.Write($"Total money spend: {totalSum:f2}");