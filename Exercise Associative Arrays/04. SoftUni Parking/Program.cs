int numberOfCommands = int.Parse(Console.ReadLine());
Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string operation = command[0];
    string userName = command[1];
    if (operation == "register")
    {
        string plateNumber = command[2];
        if (keyValuePairs.ContainsKey(userName))
        {
            Console.WriteLine($"ERROR: already registered with plate number {keyValuePairs.GetValueOrDefault(userName)}");
        }
        else
        {
            Console.WriteLine($"{userName} registered {plateNumber} successfully");
            keyValuePairs[userName] = plateNumber;
        }
    }
    else if (operation == "unregister")
    {
        if (!keyValuePairs.ContainsKey(userName))
        {
            Console.WriteLine($"ERROR: user {userName} not found");
        }
        else
        {
            Console.WriteLine($"{userName} unregistered successfully");
            keyValuePairs.Remove(userName);
        }
    }
}

foreach (var user in keyValuePairs)
{
    Console.WriteLine($"{user.Key} => {user.Value}");
}