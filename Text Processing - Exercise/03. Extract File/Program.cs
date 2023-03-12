using System.Text;

string[] input = Console.ReadLine().Split(Convert.ToChar(92));
string fileNameExtension = input[input.Length - 1];
int separatorIndex = fileNameExtension.LastIndexOf('.');
string fileName = fileNameExtension.Substring(0, separatorIndex);
string fileExtension = fileNameExtension.Substring(separatorIndex + 1);

StringBuilder output = new StringBuilder();
output.AppendLine($"File name: {fileName}");
output.AppendLine($"File extension: {fileExtension}");

Console.WriteLine(output);
