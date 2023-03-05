string[] input = Console.ReadLine()
    .Split()
    .Where(x => x.Length % 2 == 0)
    .ToArray();

foreach (var word in input)
{
    Console.WriteLine(word);
}