using System.Text.RegularExpressions;

var input = Console.ReadLine();
var regex = @"(?<day>\d{2})(?<sep>[.|\-|/])(?<month>[A-Z][a-z]{2})\<sep>(?<year>\d{4})";
var validDates = Regex.Matches(input, regex);

foreach (Match date in validDates)
{
    var day = date.Groups["day"].Value;
    var month = date.Groups["month"].Value;
    var year = date.Groups["year"].Value;
    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}
