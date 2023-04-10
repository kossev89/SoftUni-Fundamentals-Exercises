using System.ComponentModel.DataAnnotations;

string input = Console.ReadLine();
string output = input;
string command = Console.ReadLine();

while (command != "Finish")
{
    string[] commandTokens = command
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string action = commandTokens[0];
    if (action == "Replace")
    {
        string currentChar = commandTokens[1];
        string newChar = commandTokens[2];
        output = output.Replace(currentChar, newChar);
        Console.WriteLine(output);
    }
    else if (action == "Cut")
    {
        int startIndex = int.Parse(commandTokens[1]);
        int endIndex = int.Parse(commandTokens[2]);
        if (endIndex - startIndex >= output.Length)
        {
            command = Console.ReadLine();
            continue;
        }
        if (IndexIsValid(startIndex, endIndex))
        {
            output = output.Remove(startIndex, endIndex);
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Invalid indices!");
            command = Console.ReadLine();
            continue;
        }
    }
    else if (action == "Make")
    {
        string subCommand = commandTokens[1];
        if (subCommand == "Upper")
        {
            string tempString = string.Empty;
            foreach (char c in output)
            {
                char currentChar = Char.ToUpper(c);
                tempString += currentChar;
            }
            output = tempString;
            Console.WriteLine(output);
        }
        else if (subCommand == "Lower")
        {
            string tempString = string.Empty;
            foreach (char c in output)
            {
                char currentChar = Char.ToLower(c);
                tempString += currentChar;
            }
            output = tempString;
            Console.WriteLine(output);
        }
    }
    else if (action == "Check")
    {
        string stringToCheck = commandTokens[1];
        if (output.Contains(stringToCheck))
        {
            Console.WriteLine($"Message contains {stringToCheck}");
        }
        else
        {
            Console.WriteLine($"Message doesn't contain {stringToCheck}");
        }
    }
    else if (action == "Sum")
    {
        int startIndex = int.Parse(commandTokens[1]);
        int endIndex = int.Parse(commandTokens[2]);
        if (IndexIsValid(startIndex, endIndex))
        {
            int sum = 0;
            string subString = output.Substring(startIndex, endIndex - startIndex + 1);
            foreach (char c in subString)
            {
                sum += c;
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Invalid indices!");
            command = Console.ReadLine();
            continue;
        }
    }
    command = Console.ReadLine();
}

bool IndexIsValid(int startIndex, int endIndex)
{
    bool isValid = false;
    if (startIndex >= 0 && endIndex < output.Length)
    {
        isValid = true;
    }
    return isValid;
}