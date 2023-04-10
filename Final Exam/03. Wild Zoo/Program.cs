List<Animal> animals = new List<Animal>();
Dictionary<string, int> areasAnimals = new Dictionary<string, int>();

string input = Console.ReadLine();

while (input != "EndDay")
{
    string[] commandTokens = input
        .Split(": ", StringSplitOptions.RemoveEmptyEntries);
    string command = commandTokens[0];
    string[] commandInfo = commandTokens[1]
       .Split('-', StringSplitOptions.RemoveEmptyEntries);
    string name = commandInfo[0];
    Animal currentAnimal = animals.FirstOrDefault(n => n.Name == name);
    if (command == "Add")
    {
        int neededFood = int.Parse(commandInfo[1]);
        string area = commandInfo[2];
        if (!areasAnimals.ContainsKey(area))
        {
            areasAnimals.Add(area, 0);
        }
        if (animals.FirstOrDefault(n => n.Name == name) == null)
        {
            Animal animal = new Animal(name, neededFood, area);
            animals.Add(animal);
        }
        else
        {
            currentAnimal.NeededFood += neededFood;
        }
    }
    else if (command == "Feed")
    {
        int foodToFeed = int.Parse(commandInfo[1]);
        if (animals.FirstOrDefault(n => n.Name == name) != null)
        {
            currentAnimal.NeededFood -= foodToFeed;
            if (currentAnimal.IsHungry() == false)
            {
                Console.WriteLine($"{currentAnimal.Name} was successfully fed");
                animals.Remove(currentAnimal);
            }
        }
        else
        {
            input = Console.ReadLine();
            continue;
        }
    }
    input = Console.ReadLine();
}
foreach (var animal in animals)
{
    if (areasAnimals.ContainsKey(animal.Area))
    {
        areasAnimals[animal.Area]++;
    }
}

Console.WriteLine("Animals:");
foreach (var animal in animals)
{
    Console.WriteLine($" {animal.Name} -> {animal.NeededFood}g");
}
Console.WriteLine("Areas with hungry animals:");
foreach (var item in areasAnimals)
{
    if (item.Value > 0)
    {
        Console.WriteLine($" {item.Key}: {item.Value}");
    }
}

public class Animal
{
    public Animal(string name, int neededFood, string area)
    {
        Name = name;
        NeededFood = neededFood;
        Area = area;
    }

    public string Name { get; set; }
    public int NeededFood { get; set; }
    public string Area { get; set; }

    public void Feed(string name, int food)
    {
        NeededFood -= food;
    }
    public bool IsHungry()
    {
        bool isHungry = true;
        if (NeededFood <= 0)
        {
            isHungry = false;
        }
        return isHungry;
    }
}