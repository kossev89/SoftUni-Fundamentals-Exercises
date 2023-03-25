string inputString = Console.ReadLine();
string command = Console.ReadLine();

while (command != "Travel")
{
    string[] commandArg = command
        .Split(':', StringSplitOptions.RemoveEmptyEntries);
    string action = commandArg[0];
    if (action == "Add Stop")
    {
        int index = int.Parse(commandArg[1]);
        string stop = commandArg[2];
        if (IsValid(index, inputString))
        {
            inputString = inputString.Insert(index, stop);
        }
        else
        {
            Console.WriteLine(inputString);
            command = Console.ReadLine();
            continue;
        }
        Console.WriteLine(inputString);
    }
    else if (action == "Remove Stop")
    {
        int startIndex = int.Parse(commandArg[1]);
        int endIndex = int.Parse(commandArg[2]);
        int count = endIndex - startIndex + 1;
        if (IsValid(startIndex, inputString) && IsValid(endIndex, inputString))
        {
            inputString = inputString.Remove(startIndex, count);
        }
        else
        {
            Console.WriteLine(inputString);
            command = Console.ReadLine();
            continue;
        }
        Console.WriteLine(inputString);
    }
    else if (action == "Switch")
    {
        string oldString = commandArg[1];
        string newString = commandArg[2];
        if (inputString.Contains(oldString))
        {
            inputString = inputString.Replace(oldString, newString);
        }
        else
        {
            Console.WriteLine(inputString);
            command = Console.ReadLine();
            continue;
        }
        Console.WriteLine(inputString);
    }
    command = Console.ReadLine();
}
Console.WriteLine($"Ready for world tour! Planned stops: {inputString}");

static bool IsValid(int index, string inputString)
{
    bool isValid = false;
    if (index >= 0 && index < inputString.Length)
    {
        isValid = true;
    }
    return isValid;
}
