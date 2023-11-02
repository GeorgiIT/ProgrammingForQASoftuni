int[] arr = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

int index = int.Parse(Console.ReadLine());
double sum = 0;
int counter = 0;
for (int i = arr.Length - 1; i > arr.Length - 1 - index; i--)
{
    sum += arr[i];
    counter++;

}

Console.WriteLine($"{sum / counter:f2}");