using System.Text;

string[] input = Console.ReadLine().Split();
StringBuilder result = new StringBuilder();
foreach (var word in input)
{
    for (int i = 0; i < word.Length; i++)
    {
        result.Append(word);
    }
}
Console.WriteLine(result);

