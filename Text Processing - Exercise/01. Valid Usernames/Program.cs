using System.Text;

string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
List<string> validUserNames = new List<string>();

foreach (string userName in userNames)
{
    if (IsValid(userName))
    {
        validUserNames.Add(userName);
    }
}
StringBuilder output = new StringBuilder();
foreach (var user in validUserNames)
{
    output.AppendLine(user);
}
Console.WriteLine(output);





bool IsValid(string userName)
{
    bool isValid = true;

    if (userName.Length < 3 || userName.Length > 16)
    {
        isValid = false;
    }
    else
    {
        for (int i = 0; i < userName.Length; i++)
        {
            if (!Char.IsLetter(userName[i]) && !Char.IsDigit(userName[i]) && userName[i] != '-' && userName[i] != '_')
            {
                isValid = false;
                break;
            }
            else
            {
                isValid = true;
                continue;
            }
        }
    }

    return isValid;
}
