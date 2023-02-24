string inputData = Console.ReadLine();
List<Box> boxes = new List<Box>();

while (inputData != "end")
{
    string[] inputArray = inputData
        .Split()
        .ToArray();
    int serialNumber = int.Parse(inputArray[0]);
    string itemName = inputArray[1];
    int itemQuantity = int.Parse(inputArray[2]);
    decimal itemPrice = decimal.Parse(inputArray[3]);
    var box = new Box
    {
        SerialNumber = serialNumber,
        Item = new Item { Name = itemName, Price = itemPrice },
        ItemQuantity = itemQuantity,
        BoxPrice = itemQuantity * itemPrice
    };
    boxes.Add(box);
    inputData = Console.ReadLine();
}
var sortedByDescendingPrice = boxes.OrderByDescending(x => x.BoxPrice).ToList();
foreach (var box in sortedByDescendingPrice)
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.BoxPrice:f2}");
}

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Box
{
    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal BoxPrice { get; set; }
}