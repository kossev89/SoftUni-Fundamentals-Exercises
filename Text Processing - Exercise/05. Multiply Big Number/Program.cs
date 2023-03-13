using System.Text;

string number = Console.ReadLine();
string multiplier = Console.ReadLine();
string output = String.Empty;
int remainder = 0;

if (multiplier == "0")
{
    Console.WriteLine(0);
    return;
}

for (int i = number.Length - 1; i >= 0; i--)
{
    double itemToInt = Char.GetNumericValue(number[i]);
    int grossResult = (int)itemToInt * int.Parse(multiplier) + remainder;
    remainder = 0;
    int result = 0;

    if (i == number.Length - 1)
    {
        if (grossResult >= 10)
        {
            char[] chars = grossResult.ToString().ToCharArray();
            remainder = int.Parse(chars[0].ToString());
            result = int.Parse(chars[1].ToString());
            output += result;
            continue;
        }
        else
        {
            result = grossResult;
            output += result;
            continue;
        }
    }
    else
    {
        if (grossResult >= 10)
        {
            char[] chars = grossResult.ToString().ToCharArray();
            remainder = int.Parse(chars[0].ToString());
            result = int.Parse(chars[1].ToString());
        }
        else
        {
            result = grossResult;
        }
        output += result;
    }
}

if (remainder > 0)
{
    output += remainder;
}

char[] reversedOutput = output.Reverse().ToArray();
StringBuilder sb = new StringBuilder();

foreach (var item in reversedOutput)
{
    sb.Append(item);
}

Console.WriteLine(sb);
