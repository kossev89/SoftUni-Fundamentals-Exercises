int n = int.Parse(Console.ReadLine());
double[] sequence = new double[n+1];
sequence[0] = 1;
sequence[1] = 1;
for (int i = 2; i < n; i++)
{
    sequence[i] = sequence[i - 1] + sequence[i - 2];
}
Console.WriteLine(sequence[n - 1]);