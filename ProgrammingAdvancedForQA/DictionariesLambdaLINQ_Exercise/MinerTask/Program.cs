Dictionary<string, long> resources = new();
while(true)
{
    string resource = Console.ReadLine();
    if (resource == "stop")
    {
        break;
    }
    long quantity = long.Parse(Console.ReadLine());
    if (!resources.ContainsKey(resource))
    {
        resources[resource] = 0;
    }

    resources[resource] += quantity;

    

}
foreach (var pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}