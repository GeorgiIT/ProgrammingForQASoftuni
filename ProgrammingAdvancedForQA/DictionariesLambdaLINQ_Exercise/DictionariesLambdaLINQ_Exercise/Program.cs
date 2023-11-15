

string input = Console.ReadLine();

var charCount = input
    .Where(c => !char.IsWhiteSpace(c))
    .GroupBy(c => c)
    .ToDictionary(g => g.Key, g => g.Count());

foreach(var pair in charCount)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}