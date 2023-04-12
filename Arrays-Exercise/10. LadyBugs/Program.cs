using System.Data;

int fieldSize = int.Parse(Console.ReadLine());
int[] ladyBugsIndex = Console.ReadLine().Split().Select(int.Parse).ToArray(); //01
int[] field = new int[fieldSize]; // 000 = 110

for (int i = 0; i < field.Length; i++)
{
    for (int j = 0; j < ladyBugsIndex.Length; j++)
    {
        if (ladyBugsIndex[j] == i)
        {
            field[i] = 1;// 110
        }
    }
}

while (true)
{
    string command = Console.ReadLine(); // if command is 0 right 1  = field
    string direction = "";

    if (command == "end")
    {
        break;
    }
    string[] commandArray = command
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    if (command.Contains("right"))
    {
        direction = "right";
    }
    else
    {
        direction = "left";
    }

    int bugToMove = int.Parse(commandArray[0]);
    int flightLength = int.Parse(commandArray[commandArray.Length - 1]); // command 0 right 1
    if (flightLength < 0 && direction == "left")
    {
        direction = "right";
        flightLength = Math.Abs(flightLength);
    }


    for (int i = 0; i < field.Length; i++)
    {
        if (i == bugToMove && field[i] == 1 && bugToMove <= field.Length - 1) // field 110 = 011
        {
            field[i] = 0;
            if (direction == "right")
            {
                for (int j = i + (int)flightLength; j < 1000; j++)
                {
                    if (j > field.Length - 1)
                    {
                        break;
                    }
                    if (field[j] == 1)
                    {
                        j++;
                    }
                    else
                    {
                        field[j] = 1;
                    }
                }
            }
            else
            {
                for (int j = i - (int)flightLength; j > 0; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    if (field[j] == 1)
                    {
                        j--;
                    }
                    else
                    {
                        field[j] = 1;
                    }
                }
            }
        }
        else
        {
            continue;
        }
    }
}

Console.WriteLine(String.Join(' ', field));
