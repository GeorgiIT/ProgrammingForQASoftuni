int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

double result = MiddleNumber(numbers);

Console.WriteLine($"{result:f2}");

static double MiddleNumber(int[] arr)
{
    double sum = 0;
    int index = arr.Length / 2 - 1;

    for (int i = 0; i < 2; i++)
    {
        sum += arr[index];
        index++;
    }

    return sum / 2;
}
