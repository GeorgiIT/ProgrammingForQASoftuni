char[] input = Console.ReadLine().Select(s => s).Where(a => a != ' ').ToArray();


Dictionary<char, int> charCount = new();

foreach (var pair in input)
{
    if(charCount.ContainsKey(pair))
    {
        charCount[pair]++;
    }
    else
    {
        charCount.Add(pair, 1);
    }
        
}

foreach (var item in charCount)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}