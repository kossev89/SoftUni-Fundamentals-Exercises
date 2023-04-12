int dnaLength = int.Parse(Console.ReadLine());
string dnaSequence = Console.ReadLine();
if (dnaSequence == "Clone them!")
{
    dnaSequence = Console.ReadLine();
}

int bestDnaSample = 1;
int longestSequence = 0;
int bestSequenceSum = 0;
int bestSequenceStartIndex = 0;
int currentSample = 1;
int[] bestSequence = new int[dnaLength];

while (dnaSequence != "Clone them!")
{
    int[] input = dnaSequence
        .Split('!', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    if (IsValid(input))
    {
        int currentSequence = 0;
        int currentLongestSequence = 0;
        int currentStartIndex = 0;
        int currentLongestSequenceStartIndex = 0;
        int currentSum = 0;
        foreach (var item in input)
        {
            currentSum += item;
        }
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i - 1] == 1)
            {
                currentSequence = 1;
                currentStartIndex = i - 1;
                while (input[i] == 1)
                {
                    currentSequence++;
                    i++;
                    if (i >= input.Length)
                    {
                        break;
                    }
                }
                if (currentSequence > currentLongestSequence)
                {
                    currentLongestSequence = currentSequence;
                    currentLongestSequenceStartIndex = currentStartIndex;
                }
            }
            else
            {
                continue;
            }
        }
        if (currentLongestSequence > longestSequence)
        {
            IsBest(currentLongestSequence, currentLongestSequenceStartIndex, currentSum, input);
        }
        else if (currentLongestSequence == longestSequence)
        {
            if (currentLongestSequenceStartIndex < bestSequenceStartIndex)
            {
                IsBest(currentLongestSequence, currentLongestSequenceStartIndex, currentSum, input);
            }
            else if (currentLongestSequenceStartIndex == bestSequenceStartIndex)
            {
                if (currentSum > bestSequenceSum)
                {
                    IsBest(currentLongestSequence, currentLongestSequenceStartIndex, currentSum, input);
                }
                else
                {
                    dnaSequence = Console.ReadLine();
                    currentSample++;
                    continue;
                }
            }
        }
    }
    else
    {
        dnaSequence = Console.ReadLine();
        currentSample++;
        continue;
    }
    dnaSequence = Console.ReadLine();
    currentSample++;
}
Console.WriteLine($"Best DNA sample {bestDnaSample} with sum: {bestSequenceSum}.");
Console.WriteLine(String.Join(' ', bestSequence));

void IsBest(int currentLongestSequence, int currentLongestSequenceStartIndex, int currentSum, int[] input)
{
    longestSequence = currentLongestSequence;
    bestDnaSample = currentSample;
    bestSequenceStartIndex = currentLongestSequenceStartIndex;
    bestSequenceSum = currentSum;
    bestSequence = input;
}

bool IsValid(int[] input)
{
    bool isValid = true;
    if (input.Length != dnaLength)
    {
        dnaSequence = Console.ReadLine();
        currentSample++;
        isValid = false;
    }
    foreach (var item in input)
    {
        if (item != 0 && item != 1)
        {
            isValid = false;
            break;
        }
    }
    return isValid;
}