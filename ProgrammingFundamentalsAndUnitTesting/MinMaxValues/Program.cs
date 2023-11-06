int[] arr = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

int index = int.Parse(Console.ReadLine());
int maxValue = int.MinValue;
int  minValue = int.MaxValue;

for (int i = 0; i < arr.Length - index; i++)
{
    if (arr[i] > maxValue)
    {
        maxValue = arr[i];
    }
    if (arr[i] < minValue)
    {
        minValue = arr[i];
    }
}



Console.WriteLine(maxValue);
Console.WriteLine(minValue);
