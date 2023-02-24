string input = Console.ReadLine();
List<Car> cars = new List<Car>();
List<Truck> trucks = new List<Truck>();

while (input != "end")
{
    string[] inputArray = input
        .Split('/',StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string vehicleType = inputArray[0];
    string vehicleBrand = inputArray[1];
    string vehicleModel = inputArray[2];
    int weightOrPower = int.Parse(inputArray[3]);

    if (vehicleType == "Car")
    {
        var car = new Car { Brand = vehicleBrand, Model = vehicleModel, HorsePower = weightOrPower };
        cars.Add(car);
    }
    else if (vehicleType == "Truck")
    {
        var truck = new Truck { Brand = vehicleBrand, Model = vehicleModel, Weight = weightOrPower };
        trucks.Add(truck);
    }
    input = Console.ReadLine();
}
cars.Sort((x, y) => string.Compare(x.Brand, y.Brand));
trucks.Sort((x, y) => string.Compare(x.Brand, y.Brand));
if (cars.Count > 0 && trucks.Count > 0)
{
    PrintCars(cars);
    PrintTrucks(trucks);
}
else if (cars.Count > 0 && trucks.Count == 0)
{
    PrintCars(cars);
}
else if (cars.Count == 0 && trucks.Count > 0)
{
    PrintTrucks(trucks);
}

void PrintTrucks(List<Truck> trucks)
{
    Console.WriteLine("Trucks:");
    foreach (var truck in trucks)
    {
        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
    }
}

void PrintCars(List<Car> cars)
{
    Console.WriteLine("Cars:");
    foreach (var car in cars)
    {
        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
    }
}

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}
class Catalogue
{
    public List<Truck> trucks { get; set; }
    public List<Car> cars { get; set; }

}

