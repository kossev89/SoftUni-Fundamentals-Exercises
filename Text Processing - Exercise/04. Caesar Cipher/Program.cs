using System.Text;

string input = Console.ReadLine();
StringBuilder output = new StringBuilder();

foreach (char item in input)
{
    int currentItem = item + 3;
    char encryptedLetter = (char)currentItem;
    output.Append(encryptedLetter.ToString());
}

Console.WriteLine(output.ToString());