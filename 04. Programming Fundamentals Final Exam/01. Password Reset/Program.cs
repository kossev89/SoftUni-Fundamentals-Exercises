using System.Text;

string input = Console.ReadLine();
string command = Console.ReadLine();
string password = input;

while (command != "Done")
{
    string[] commandTokens = command
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string action = commandTokens[0];
    if (action == "TakeOdd")
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < password.Length; i++)
        {
            if (i % 2 != 0)
            {
                sb.Append(password[i]);
            }
        }
        password = sb.ToString();
        Console.WriteLine(password);
    }
    else if (action == "Cut")
    {
        int index = int.Parse(commandTokens[1]);
        int length = int.Parse(commandTokens[2]);
        password = password.Remove(index, length);
        Console.WriteLine(password);
    }
    else if (action == "Substitute")
    {
        string substring = commandTokens[1];
        string substitute = commandTokens[2];
        if (password.Contains(substring))
        {
            password = password.Replace(substring, substitute);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"Your password is: {password}");