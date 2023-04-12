int n = int.Parse(Console.ReadLine());

int[] numberOfWagons = new int[n];
int totalPeople = 0;
for (int i = 0; i < numberOfWagons.Length; i++)
{
    int numberOfPeople = int.Parse(Console.ReadLine());
    numberOfWagons[i] = numberOfPeople;
    totalPeople += numberOfPeople;
}
for (int i = 0; i < numberOfWagons.Length; i++)
{
    Console.Write(numberOfWagons[i] + " ");
}
Console.WriteLine();
Console.WriteLine(totalPeople);