using System.Text;
using System.Text.RegularExpressions;

string pattern = @"^(\@\#+)(?<info>[A-Z][\dA-Za-z]{4,}[A-Z])(\@\#+)$";
Regex regex = new Regex(pattern);

int numberOfBarcodes = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfBarcodes; i++)
{
    string input = Console.ReadLine();
    Match match = regex.Match(input);
    if (match.Success)
    {
        StringBuilder stringBuilder = new StringBuilder();
        char[] chars = match.Groups["info"].Value.ToCharArray();
        bool containsDigits = false;
        foreach (char c in chars)
        {
            if (Char.IsDigit(c))
            {
                containsDigits = true;
                break;
            }
        }
        if (containsDigits)
        {
            foreach (var item in chars)
            {
                if (Char.IsDigit(item))
                {
                    stringBuilder.Append(item.ToString());
                }
            }
            Console.WriteLine($"Product group: {stringBuilder}");
        }
        else
        {
            Console.WriteLine("Product group: 00");
        }
    }
    else
    {
        Console.WriteLine("Invalid barcode");
    }
}