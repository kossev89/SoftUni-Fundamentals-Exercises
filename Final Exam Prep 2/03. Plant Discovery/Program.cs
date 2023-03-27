using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

int numberOfPlants = int.Parse(Console.ReadLine());
List<Plant> plants = new List<Plant>();

for (int i = 0; i < numberOfPlants; i++)
{
    string[] plantInfo = Console.ReadLine()
        .Split("<->", StringSplitOptions.RemoveEmptyEntries);
    string plantName = plantInfo[0];
    int plantRarity = int.Parse(plantInfo[1]);
    Plant currentPlant = plants.FirstOrDefault(p => p.Name == plantName);
    if (!plants.Contains(currentPlant))
    {
        Plant plant = new Plant(plantName, plantRarity);
        plants.Add(plant);
    }
    else
    {
        currentPlant.Update(plantRarity);
    }
}
string commandInput = Console.ReadLine();

while (commandInput != "Exhibition")
{
    string[] commandArg = commandInput
        .Split(": ", StringSplitOptions.RemoveEmptyEntries);
    string[] additionalArg = commandArg[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
    string action = commandArg[0];
    string name = additionalArg[0];
    Plant currentPlant = plants.FirstOrDefault(p => p.Name == name);
    if (currentPlant == null)
    {
        Console.WriteLine("error");
        commandInput = Console.ReadLine();
        continue;
    }
    if (action == "Rate")
    {
        double rating = double.Parse(additionalArg[1]);
        currentPlant.Rate(rating);
    }
    else if (action == "Update")
    {
        int rarity = int.Parse(additionalArg[1]);
        currentPlant.Update(rarity);
    }
    else if (action == "Reset")
    {
        currentPlant.Reset();
    }
    commandInput = Console.ReadLine();
}
Console.WriteLine("Plants for the exhibition:");
foreach (var plant in plants)
{
    Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.AvaregeRating():f2}");
}



public class Plant
{
    public Plant(string name, int rarity)
    {
        Name = name;
        Rarity = rarity;
        Rating = new List<double>();
    }

    public string Name { get; set; }
    public int Rarity { get; set; }
    public List<double> Rating { get; set; }

    public void Rate(double rating)
    {
        Rating.Add(rating);
    }
    public void Update(int rarity)
    {
        Rarity = rarity;
    }
    public void Reset()
    {
        Rating.Clear();
    }
    public double AvaregeRating()
    {
        double averageRating = Rating.Sum() / Rating.Count();
        if (Rating.Count == 0)
        {
            averageRating = 0;
        }
        return averageRating;
    }
}