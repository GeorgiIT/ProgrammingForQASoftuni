int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> kvp = new();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();
    if (kvp.ContainsKey(word))
    {
        kvp[word].Add(synonym);
    }
    else
    {
        kvp.Add(word, new List<string>() { synonym });
    }
    
}
foreach(var word in kvp)
{
    Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)} ");
    
}