using System.Text;

char[] input = Console.ReadLine().ToCharArray();
List<char> digits = new List<char>();
List<char> letters = new List<char>();
List<char> symbols = new List<char>();

foreach (var item in input)
{
    if (Char.IsDigit(item))
    {
        digits.Add(item);
    }
    else if (Char.IsLetter(item))
    {
        letters.Add(item);
    }
    else
    {
        symbols.Add(item);
    }
}

StringBuilder output = new StringBuilder();
foreach (var digit in digits)
{
    output.Append(digit);
}
output.AppendLine();
foreach (var letter in letters)
{
    output.Append(letter);
}
output.AppendLine();
foreach (var symbol in symbols)
{
    output.Append(symbol);
}

Console.WriteLine(output);