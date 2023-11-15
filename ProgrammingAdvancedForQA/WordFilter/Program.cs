var input = Console.ReadLine().Split(" ").Where(s => s.Length % 2 == 0).ToArray();

foreach (var line in input)
{
    Console.WriteLine(line);
}