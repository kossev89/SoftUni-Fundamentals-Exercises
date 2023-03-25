int numberOfPieces = int.Parse(Console.ReadLine());
Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();

for (int i = 0; i < numberOfPieces; i++)
{
    string[] pieceInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
    string piece = pieceInfo[0];
    string composer = pieceInfo[1];
    string key = pieceInfo[2];
    if (!pieces.ContainsKey(piece))
    {
        pieces[piece] = new string[2] { composer, key };
    }
}

string commandInput = Console.ReadLine();

while (commandInput != "Stop")
{
    string[] commandArg = commandInput.Split('|', StringSplitOptions.RemoveEmptyEntries);
    string action = commandArg[0];
    if (action == "Add")
    {
        string piece = commandArg[1];
        string composer = commandArg[2];
        string key = commandArg[3];
        if (pieces.ContainsKey(piece))
        {
            Console.WriteLine($"{piece} is already in the collection!");
            commandInput = Console.ReadLine();
            continue;
        }
        else
        {
            pieces[piece] = new string[2] { composer, key };
            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
    }
    else if (action == "Remove")
    {
        string piece = commandArg[1];
        if (pieces.ContainsKey(piece))
        {
            pieces.Remove(piece);
            Console.WriteLine($"Successfully removed {piece}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
    else if (action == "ChangeKey")
    {
        string piece = commandArg[1];
        string newKey = commandArg[2];
        if (pieces.ContainsKey(piece))
        {
            pieces[piece][1] = newKey;
            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
    commandInput = Console.ReadLine();
}

foreach (var item in pieces)
{
    Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
}