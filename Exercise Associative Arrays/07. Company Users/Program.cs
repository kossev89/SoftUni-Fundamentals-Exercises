Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();
string command = Console.ReadLine();

while (command != "End")
{
    string[] inputTokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    string companyName = inputTokens[0];
    string employeeId = inputTokens[1];

    if (!companyEmployees.ContainsKey(companyName))
    {
        companyEmployees[companyName] = new List<string>();
    }

    if (!companyEmployees[companyName].Contains(employeeId))
    {
        companyEmployees[companyName].Add(employeeId);
    }

    command = Console.ReadLine();
}

foreach (var company in companyEmployees)
{
    Console.WriteLine(company.Key);
    foreach (var id in company.Value)
    {
        Console.WriteLine($"-- {id}");
    }
}