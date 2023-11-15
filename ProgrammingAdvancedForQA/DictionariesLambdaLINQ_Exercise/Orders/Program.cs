Dictionary<string, List<decimal>> storage = new();

while (true)
{
    string[] inputArr = Console.ReadLine().Split(" ").ToArray();
    string product = inputArr[0];
    if(product == "buy")
    {
        break;
    }
    decimal price = Convert.ToDecimal(inputArr[1]);
    decimal quantity = Convert.ToDecimal(inputArr[2]);

   
    if (!storage.ContainsKey(product))
    {
        storage.Add(product, new List<decimal>() { price , quantity});
    }
    else
    {
        storage[product][0] = price;
        storage[product][1] += quantity;
    }
    
    



}
foreach (var pair in storage)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value[0] * pair.Value[1]:f2}");
}