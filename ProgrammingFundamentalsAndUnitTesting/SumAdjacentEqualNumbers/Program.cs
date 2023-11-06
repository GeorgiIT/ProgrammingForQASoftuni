List<int> numbers = Console.ReadLine()
           .Split(" ")
           .Select(int.Parse)
           .ToList();

bool repeat = false;

while (true)
{
    List<int> condense = new List<int>();

    for (int i = 0; i < numbers.Count; i++)
    {
        if (i <= numbers.Count - 1 )
        {
            if (numbers[i] == numbers[i + 1])
            {
                condense.Add(numbers[i] + numbers[i]);
                repeat = true;
                i++;
            }
            else
            {
                repeat = false;
                condense.Add(numbers[i]);
            }
        }

        
    }
    numbers = condense;
}