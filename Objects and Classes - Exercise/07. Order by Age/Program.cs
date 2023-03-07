string inputInformation = Console.ReadLine();
List<Person> persons = new List<Person>();

while (inputInformation != "End")
{
    string[] personInfo = inputInformation
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string name = personInfo[0];
    string iD = personInfo[1];
    int age = int.Parse(personInfo[2]);
    bool iDexists = false;
    int overwriteIndex = 0;
    for (int i = 0; i < persons.Count; i++)
    {
        if (persons[i].ID == iD)
        {
            iDexists = true;
            overwriteIndex = i;
        }
    }
    if (iDexists)
    {
        persons[overwriteIndex].Name = name;
        persons[overwriteIndex].Age = age;
    }
    else
    {
        Person person = new Person(name, iD, age);
        persons.Add(person);
    }
    inputInformation = Console.ReadLine();
}
List<Person> orderedList = persons.OrderBy(x => x.Age).ToList();
foreach (var item in orderedList)
{
    Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
}

public class Person
{
    public Person(string name, string iD, int age)
    {
        Name = name;
        ID = iD;
        Age = age;
    }

    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}