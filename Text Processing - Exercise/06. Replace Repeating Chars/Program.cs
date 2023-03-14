string input = Console.ReadLine();
List<string> output = new List<string>();

for (int i = 1; i < input.Length; i++)
{
    if (input[i] == input[i - 1])
    {
        continue;
    }
    output.Add(input[i - 1].ToString());
}
output.Add(input[input.Length - 1].ToString());

foreach (var item in output)
{
    Console.Write(item);
}