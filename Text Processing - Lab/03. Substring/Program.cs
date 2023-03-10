string firstString = Console.ReadLine();
string secondString = Console.ReadLine();
string result = secondString;

while (result.Contains(firstString) == true)
{
    int index = result.IndexOf(firstString);
    result = result.Remove(index, firstString.Length);
}

Console.WriteLine(result);


