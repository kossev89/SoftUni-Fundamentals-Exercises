string recource = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

while (recource != "stop")
{
    if (!keyValuePairs.ContainsKey(recource))
    {
        keyValuePairs[recource] = 0;
    }
    keyValuePairs[recource] += quantity;
    recource = Console.ReadLine();
    if (recource=="stop")
    {
        break;
    }
    quantity = int.Parse(Console.ReadLine());
}

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

