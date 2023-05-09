int numberOfRows = int.Parse(Console.ReadLine());
int[] row = new int[] { 1 };

for (int i = 1; i <= numberOfRows; i++)
{
    Console.WriteLine(string.Join(' ', row));
    int[] ints = new int[i + 1];
    for (int j = 0; j < ints.Length; j++)
    {
        if (j == 0 || j == ints.Length - 1)
        {
            ints[j] = 1;
        }
        else
        {
            ints[j] = row[j] + row[j - 1];
        }
    }
    row = ints;
}