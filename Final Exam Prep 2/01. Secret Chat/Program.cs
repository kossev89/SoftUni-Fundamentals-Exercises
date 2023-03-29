string concealedMessage = Console.ReadLine();
string command = Console.ReadLine();
string output = concealedMessage;

while (command != "Reveal")
{
    string[] commandArg = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
    string action = commandArg[0];
    if (action == "InsertSpace")
    {
        int index = int.Parse(commandArg[1]);
        output = output.Insert(index, " ");
        Console.WriteLine(output);
    }
    else if (action == "Reverse")
    {
        string substring = commandArg[1];
        if (output.Contains(substring))
        {
            output = output.Remove(output.IndexOf(substring),substring.Length);
            char[] substringTocharArray = substring.ToCharArray();
            Array.Reverse(substringTocharArray);
            string reversed = new string(substringTocharArray);
            output = output + reversed;
        }
        else
        {
            Console.WriteLine("error");
            Console.WriteLine(output);
            command = Console.ReadLine();
            continue;
        }
        Console.WriteLine(output);
    }
    else if (action == "ChangeAll")
    {
        string substring = commandArg[1];
        string replacement = commandArg[2];
        output = output.Replace(substring, replacement);
        Console.WriteLine(output);
    }
    command = Console.ReadLine();
}
Console.WriteLine($"You have a new text message: {output}");
