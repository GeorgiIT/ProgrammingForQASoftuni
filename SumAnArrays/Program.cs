using System.Diagnostics.Metrics;
using System.Threading.Channels;
static void SumArray(string[] numbers)
{
    int[] intNumbers = new int[numbers.Length];
    int counter = 0;
    foreach (string number in numbers)
    {
        intNumbers[counter] = int.Parse(number);
        counter++;
    }
    Console.WriteLine(intNumbers.Sum());
}

string[] strNumbers = Console.ReadLine().Split(' ').ToArray();
SumArray(strNumbers);
