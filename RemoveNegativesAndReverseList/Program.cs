﻿List<int> numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] < 0)
    {
        numbers.Remove(numbers[i]);
        i--;
    }
}
if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    numbers.Reverse();
    foreach (var number in numbers)
    {
        Console.Write(number + " ");
    }
}
