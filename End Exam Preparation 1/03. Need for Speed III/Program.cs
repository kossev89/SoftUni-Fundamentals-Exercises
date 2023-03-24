int carsCount = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();

for (int i = 0; i < carsCount; i++)
{
    string[] carInfo = Console.ReadLine()
        .Split('|', StringSplitOptions.RemoveEmptyEntries);
    string name = carInfo[0];
    int mileage = int.Parse(carInfo[1]);
    int fuel = int.Parse(carInfo[2]);
    Car car = new Car(name, mileage, fuel);
    cars.Add(car);
}

string commandInput = Console.ReadLine();

while (commandInput != "Stop")
{
    string[] commandArg = commandInput
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
    string command = commandArg[0];

    if (command == "Drive")
    {
        string name = commandArg[1];
        int distanceToMove = int.Parse(commandArg[2]);
        int fuelNeeded = int.Parse(commandArg[3]);
        Car currentCar = cars.FirstOrDefault(c => c.Name == name);
        if (currentCar == null)
        {
            continue;
        }
        currentCar.Drive(distanceToMove, fuelNeeded);
        if (currentCar.Mileage >= 100000)
        {
            Console.WriteLine($"Time to sell the {name}!");
            cars.Remove(currentCar);
        }
    }
    else if (command == "Refuel")
    {
        string name = commandArg[1];
        int fuelToRefill = int.Parse(commandArg[2]);
        Car currentCar = cars.FirstOrDefault(c => c.Name == name);
        if (currentCar == null)
        {
            continue;
        }
        currentCar.Refuel(fuelToRefill);
    }
    else if (command == "Revert")
    {
        string name = commandArg[1];
        int kilometersToRevert = int.Parse(commandArg[2]);
        Car currentCar = cars.FirstOrDefault(c => c.Name == name);
        if (currentCar == null)
        {
            continue;
        }
        currentCar.Revert(kilometersToRevert);
    }
    commandInput = Console.ReadLine();
}
foreach (var car in cars)
{
    Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
}

public class Car
{
    public Car(string name, int mileage, int fuel)
    {
        Name = name;
        Mileage = mileage;
        Fuel = fuel;
    }
    public string Name { get; set; }
    public int Mileage { get; set; }
    public int Fuel { get; set; }

    public void Drive(int distanceToMove, int fuelNeeded)
    {
        if (fuelNeeded > Fuel)
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }
        else
        {
            Mileage += distanceToMove;
            Fuel -= fuelNeeded;
            Console.WriteLine($"{Name} driven for {distanceToMove} kilometers. {fuelNeeded} liters of fuel consumed.");
        }
    }
    public void Refuel(int fuelToRefill)
    {
        int fuelAdded = 0;
        int fuelConsumed = 75 - Fuel;
        Fuel += fuelToRefill;
        if (Fuel > 75)
        {
            Fuel = 75;
            fuelAdded = fuelConsumed;
        }
        else
        {
            fuelAdded = fuelToRefill;
        }
        Console.WriteLine($"{Name} refueled with {fuelAdded} liters");
    }
    public void Revert(int kilometersToRevert)
    {
        Mileage -= kilometersToRevert;
        if (Mileage < 10000)
        {
            Mileage = 10000;
        }
        else
        {
            Console.WriteLine($"{Name} mileage decreased by {kilometersToRevert} kilometers");
        }
    }
}