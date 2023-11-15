Dictionary<string, long> resorces = new();

while(true)
{
    string resorce = Console.ReadLine();
    if(resorce == "stop")
    {
        break;
    }
    long quantity = long.Parse(Console.ReadLine());

    if(resorces.ContainsKey(resorce))
    {
        resorces[resorce] += quantity;
    }
    else
    {
        resorces.Add(resorce, quantity);
    }
}

foreach (var pair in resorces)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}