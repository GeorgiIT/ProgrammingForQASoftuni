List<int> numbers = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();

while (numbers.Count > 1)
{
    List<int> condensedNumbers = new List<int>();

    for (int i = 0; i < numbers.Count - 1; i++)
    {
        condensedNumbers.Add(numbers[i] + numbers[i + 1]);
    }

    numbers = condensedNumbers;
}

Console.WriteLine("Condensed result: " + numbers[0]);