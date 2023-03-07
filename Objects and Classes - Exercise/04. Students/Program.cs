using System.Runtime.CompilerServices;

int studentsCount = int.Parse(Console.ReadLine());
List<Student> studentsList = new List<Student>();

for (int i = 0; i < studentsCount; i++)
{
    string[] information = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string firstName = information[0];
    string lastName = information[1];
    double grade = double.Parse(information[2]);
    Student student = new Student(firstName, lastName, grade);
    studentsList.Add(student);
}
var orderedList = studentsList.OrderByDescending(x => x.Grade).ToList();
foreach (var student in orderedList)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
}


class Student
{
    public Student(string firstName, string lastName, double grade)
{
    FirstName = firstName;
    LastName = lastName;
    Grade = grade;
}

public string FirstName { get; set; }
public string LastName { get; set; }
public double Grade { get; set; }
}