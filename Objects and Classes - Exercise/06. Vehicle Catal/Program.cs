using System.Linq;

string command = Console.ReadLine();
List<Vehicle> vehicles = new List<Vehicle>();

while (command != "End")
{
    string[] vehicleInformation = command
        .Split()
        .ToArray();
    string type = vehicleInformation[0];
    string model = vehicleInformation[1];
    string color = vehicleInformation[2];
    int horsePower = int.Parse(vehicleInformation[3]);
    Vehicle vehicle = new Vehicle(type, model, color, horsePower);
    vehicles.Add(vehicle);
    command = Console.ReadLine();
}

string searchByModel = Console.ReadLine();

while (searchByModel != "Close the Catalogue")
{
    Vehicle vehicleModel = vehicles.FirstOrDefault(x => x.Model == searchByModel);
    vehicleModel.PrintVehicleInfo(vehicleModel.Type, vehicleModel.Model, vehicleModel.Color, vehicleModel.HorsePower);
    searchByModel = Console.ReadLine();
}

List<Vehicle> trucks = new List<Vehicle>();
List<Vehicle> cars = new List<Vehicle>();
double trucksTotalHorsepower = 0;
double carsTotalHorsepower = 0;

foreach (var vehicle in vehicles)
{
    if (vehicle.Type == "truck")
    {
        trucks.Add(vehicle);
        trucksTotalHorsepower += vehicle.HorsePower;
    }
    else
    {
        cars.Add(vehicle);
        carsTotalHorsepower += vehicle.HorsePower;
    }
}

if (cars.Count > 0 && trucks.Count > 0)
{
    Console.WriteLine($"Cars have average horsepower of: {carsTotalHorsepower / (cars.Count):f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {trucksTotalHorsepower / (trucks.Count):f2}.");
}
else if (cars.Count > 0 && trucks.Count == 0)
{
    Console.WriteLine($"Cars have average horsepower of: {carsTotalHorsepower / (cars.Count):f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
}
else if (cars.Count == 0 && trucks.Count > 0)
{
    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {trucksTotalHorsepower / (trucks.Count):f2}.");
}

public class Vehicle
{
    public Vehicle(string type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int HorsePower { get; set; }

    public void PrintVehicleInfo(string type, string model, string color, int horsePower)
    {
        if (type == "car")
        {
            Console.WriteLine($"Type: Car");
        }
        else
        {
            Console.WriteLine($"Type: Truck");
        }
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Horsepower: {horsePower}");
    }
}