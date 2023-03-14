using System.Text;

string number = Console.ReadLine();
string multiplier = Console.ReadLine();
int remainder = 0;
StringBuilder output = new StringBuilder();

if (multiplier == "0")
{
    Console.WriteLine(0);
    return;
}

for (int i = number.Length - 1; i >= 0; i--)
{
    double itemToInt = Char.GetNumericValue(number[i]);
    int product = (int)itemToInt * int.Parse(multiplier) + remainder;
    remainder = 0;
    int result;

    if (i == number.Length - 1)
    {
        if (product >= 10)
        {
            char[] productArray = product.ToString().ToCharArray();
            remainder = int.Parse(productArray[0].ToString());
            result = int.Parse(productArray[1].ToString());
            output.Insert(0, result);
            continue;
        }
        else
        {
            result = product;
            output.Insert(0, result);
            continue;
        }
    }
    else
    {
        if (product >= 10)
        {
            char[] chars = product.ToString().ToCharArray();
            remainder = int.Parse(chars[0].ToString());
            result = int.Parse(chars[1].ToString());
        }
        else
        {
            result = product;
        }
        output.Insert(0, result);
    }
}

if (remainder > 0)
{
    output.Insert(0, remainder);
}

Console.WriteLine(output);
