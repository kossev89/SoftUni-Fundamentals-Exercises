string encodedMessage = Console.ReadLine();
string message = encodedMessage;

string commandInput = Console.ReadLine();

while (commandInput != "Decode")
{
    string[] commandArg = commandInput
        .Split('|', StringSplitOptions.RemoveEmptyEntries);
    string command = commandArg[0];

    if (command == "Move")//o	Moves the first n letters to the back of the string
    {
        int numberOfLetters = int.Parse(commandArg[1]);
        string lettersToMove = message.Substring(0, numberOfLetters);
        message = message.Remove(0, numberOfLetters) + lettersToMove;
    }
    else if (command == "Insert")// o	Inserts the given value before the given index in the string
    {
        int index = int.Parse(commandArg[1]);
        string value = commandArg[2];
        message = message.Insert(index, value);
    }
    else if (command == "ChangeAll")//o	Changes all occurrences of the given substring with the replacement text
    {
        string substring = commandArg[1];
        string replacement = commandArg[2];
        message = message.Replace(substring, replacement);
    }
    commandInput = Console.ReadLine();
}
Console.WriteLine($"The decrypted message is: {message}");