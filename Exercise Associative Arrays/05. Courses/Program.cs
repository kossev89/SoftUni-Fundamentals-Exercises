Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();
string inputData = Console.ReadLine();

while (inputData != "end")
{
    string[] inputTokens = inputData
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
    string courseName = inputTokens[0];
    string studentName = inputTokens[1];

    if (!courseInfo.ContainsKey(courseName))
    {
        courseInfo[courseName] = new List<string>();
    }
    courseInfo[courseName].Add(studentName);
    inputData = Console.ReadLine();
}

foreach (var course in courseInfo)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");
    foreach (var student in course.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}