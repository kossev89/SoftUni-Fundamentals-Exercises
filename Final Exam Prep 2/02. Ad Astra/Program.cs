using System.Text;
using System.Text.RegularExpressions;

string pattern = @"(\||\#)(?<item>[^\d\|][A-Za-z]*( )?[A-Za-z]*)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
Regex regex = new Regex(pattern);
string input = Console.ReadLine();

MatchCollection MatchCollection = regex.Matches(input);
List<StringBuilder> output = new List<StringBuilder>();

int totalCalories = 0;

foreach (Match item in MatchCollection)
{
    string foodName = item.Groups["item"].Value.ToString();
    string expDate = item.Groups["date"].Value.ToString();
    int calories = int.Parse(item.Groups["calories"].Value);
    totalCalories += calories;
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append($"Item: {foodName}, Best before: {expDate}, Nutrition: {calories}");
    output.Add(stringBuilder);
}

int daysToLast = totalCalories / 2000;
Console.WriteLine($"You have food to last you for: {daysToLast} days!");

foreach (var item in output)
{
    Console.WriteLine(item);
}

