List<int> firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int count = 1;

if (firstNumbers.Count > secondNumbers.Count)
{
    
    foreach (int number in secondNumbers)
    {
        firstNumbers.Insert(count, number);
        count += 2;
    }
    foreach (int number in firstNumbers)
    {
        Console.Write(number + " ");
    }
}
else
{
    count = 0;
    foreach (int number in firstNumbers)
    {
        secondNumbers.Insert(count, number);
        count += 2;
    }
    foreach (int number in secondNumbers)
    {
        Console.Write(number + " ");
    }
}
