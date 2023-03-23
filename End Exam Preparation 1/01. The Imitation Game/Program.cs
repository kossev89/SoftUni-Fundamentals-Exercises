string encodedMessage = Console.ReadLine();
string message = encodedMessage;
string commandInput = Console.ReadLine();

while (commandInput != "Decode")
{
    string[] commandArg = commandInput
        .Split('|', StringSplitOptions.RemoveEmptyEntries);
    string command = commandArg[0];

    if (command == "Move")
    {
        int numberOfLetters = int.Parse(commandArg[1]);
        string lettersToMove = message.Substring(0, numberOfLetters);
        message = message.Remove(0, numberOfLetters) + lettersToMove;
    }
    else if (command == "Insert")
    {
        int index = int.Parse(commandArg[1]);
        string value = commandArg[2];
        message = message.Insert(index, value);
    }
    else if (command == "ChangeAll")
    {
        string substring = commandArg[1];
        string replacement = commandArg[2];
        message = message.Replace(substring, replacement);
    }
    commandInput = Console.ReadLine();
}
Console.WriteLine($"The decrypted message is: {message}");