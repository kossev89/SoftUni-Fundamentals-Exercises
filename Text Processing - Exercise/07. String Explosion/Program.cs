using System.Text;

string input = Console.ReadLine();
int bombStrength = 0;
StringBuilder output = new StringBuilder();

for (int i = 0; i < input.Length; i++)
{
    if (Char.IsDigit(input[i]))
    {
        bombStrength--;
        continue;
    }
    if (input[i] == '>')
    {
        output.Append(input[i]);
        bombStrength += int.Parse(input[i + 1].ToString());
        continue;
    }
    else if (bombStrength > 0)
    {
        bombStrength--;
        continue;
    }
    else
    {
        output.Append(input[i]);
        continue;
    }
}
Console.WriteLine(output);