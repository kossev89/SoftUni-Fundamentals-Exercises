Dictionary<string, double[]> productInfo = new Dictionary<string, double[]>();
string input = Console.ReadLine();

while (input != "buy")
{
    string[] infoArray = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string productName = infoArray[0];
    double price = double.Parse(infoArray[1]);
    double quantity = double.Parse(infoArray[2]);

    if (!productInfo.ContainsKey(productName))
    {
        productInfo[productName] = new double[2];
    }

    productInfo[productName][0] = price;
    productInfo[productName][1] += quantity;
    input = Console.ReadLine();
}

foreach (var product in productInfo)
{
    Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
}
