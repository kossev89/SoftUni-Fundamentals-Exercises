int[] inputArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] firstRow = new int[inputArray.Length / 2];
int[] secondRow = new int[inputArray.Length / 2];
int[] secondRowFirstHalf = new int[secondRow.Length / 2];
int[] secondRowSecondHalf = new int[secondRow.Length / 2];
int delimeter = firstRow.Length / 2;
firstRow = inputArray.Skip(delimeter).SkipLast(delimeter).ToArray();
secondRowFirstHalf = inputArray.Take(delimeter).Reverse().ToArray();
secondRowSecondHalf = inputArray.TakeLast(delimeter).Reverse().ToArray();
secondRow = secondRowFirstHalf.Concat(secondRowSecondHalf).ToArray();
int[] output = new int[inputArray.Length / 2];

for (int i = 0; i < output.Length; i++)
{
    output[i] = firstRow[i] + secondRow[i];
}

Console.WriteLine(string.Join(' ', output));
