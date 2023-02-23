string information = Console.ReadLine();
List<Student> students = new List<Student>();

while (information != "end")
{
    string[] studentInfo = information.Split().ToArray();
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    int age = int.Parse(studentInfo[2]);
    string town = studentInfo[3];

    var student = new Student { firstName = firstName, lastName = lastName, age = age, homeTown = town };
    students.Add(student);
    information = Console.ReadLine();
}

string cityName = Console.ReadLine();
foreach (var student in students)
{
    if (cityName == student.homeTown)
    {
        Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
    }
}

class Student
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string homeTown { get; set; }
}

