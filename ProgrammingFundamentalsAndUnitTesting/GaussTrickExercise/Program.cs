List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

List<int> sums = new List<int>();
for (int i = 0; i < numbers.Count / 2; i++)
{
    sums.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
}
int middleIndex = numbers.Count / 2;

foreach (int i in sums)
{
    Console.Write(i + " ");
}

if (numbers.Count % 2 != 0)
{
    Console.Write(numbers[middleIndex]);
}