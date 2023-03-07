using System.Xml.Linq;

Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();
int totalInputs = int.Parse(Console.ReadLine());

for (int i = 0; i < totalInputs; i++)
{
    string studentName = Console.ReadLine();
    double studentGrade = double.Parse(Console.ReadLine());
    if (!studentsInfo.ContainsKey(studentName))
    {
        studentsInfo[studentName] = new List<double>();
    }
    studentsInfo[studentName].Add(studentGrade);
}

foreach (var student in studentsInfo)
{
    double avrGrade = student.Value.Sum() / student.Value.Count;
    if (avrGrade>=4.50)
    {
        Console.WriteLine($"{student.Key} –> {avrGrade:f2}");
    } 
}