using System.Text.RegularExpressions;

string regex = @"\+359([ |-])[2]\1\d{3}\1\d{4}\b";
string input = Console.ReadLine();

MatchCollection validNumber = Regex.Matches(input, regex);

Console.WriteLine(string.Join(", ", validNumber));
