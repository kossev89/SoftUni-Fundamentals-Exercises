using System.Text;
using System.Text.RegularExpressions;


Regex regex = new Regex(@"^[^\%\|\$\.]*?\%(?<customerName>[A-z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$");

decimal totalIncome = 0;
StringBuilder output = new StringBuilder();
string input = Console.ReadLine();

while (input != "end of shift")
{
    Match match = regex.Match(input);
    decimal totalPrice = 0;

    if (match.Success)
    {
        string name = match.Groups["customerName"].ToString();
        string product = match.Groups["product"].ToString();
        int count = int.Parse(match.Groups["count"].Value);
        decimal price = decimal.Parse(match.Groups["price"].Value);
        totalPrice = count * price;
        totalIncome += totalPrice;
        output.AppendLine($"{name}: {product} - {totalPrice:f2}");
    }
    input = Console.ReadLine();
}
Console.Write(output);
Console.WriteLine($"Total income: {totalIncome:f2}.");

