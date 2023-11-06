using System.Xml.Linq;
static void ContainsNumber(List<int> numbers, int element)
{
    bool result = false;
    if (numbers.Contains(element))
    {
        result = true;
    }

    if(result)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No such number");
    }
}

static void PrintEven(List<int> numbers)
{
    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Console.Write(numbers[i] + " ");
        }
    }
    Console.WriteLine();
}

static void PrintOdd(List<int> numbers)
{
    for(int i = 0;i < numbers.Count; i++)
    {
        if (numbers[i] % 2 != 0)
        {
            Console.Write(numbers[i] + " ");
        }
    }
    Console.WriteLine();
}

static void GetSum(List<int> numbers)
{
    
    Console.WriteLine(numbers.Sum());
}

static void FilterMethod(List<int> numbers, string condition, int element)
{
    if (condition == "<")
    {
        foreach(int i in numbers)
        {
            if(i < element)
            {
                Console.Write(i + " ");
            }
        }    
    }
    else if(condition == ">")
    {
        foreach (int i in numbers)
        {
            if (i > element)
            {
                Console.Write(i + " ");
            }
        }
    }
    else if( condition == ">=")
    {
        foreach (int i in numbers)
        {
            if (i >= element)
            {
                Console.Write(i + " ");
            }
        }
    }
    else if (condition == "<=")
    {
        foreach (int i in numbers)
        {
            if (i <= element)
            {
                Console.Write(i + " ");
            }
        }
    }
    Console.WriteLine();
}


List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

int element = 0;
string condition = string.Empty;
bool isSymbolsThere = false;


while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }
    List<string> commands = new List<string>(command.Split(" "));
    if (commands.Count > 1)
    {
        if (commands[1].Contains("<") || commands[1].Contains(">") || commands[1].Contains("<=") || commands[1].Contains(">="))
        {
            isSymbolsThere = true;
            condition = commands[1];
            element = int.Parse(commands[2]);
        }
        else if (isSymbolsThere == false)
        {
            element = int.Parse(commands[1]);

        }
    }
    
    

    switch (commands[0])
    {
        case "Contains":
            ContainsNumber(numbers, element);
            break;
        case "PrintEven":
            PrintEven(numbers);
            break;
        case "PrintOdd":
            PrintOdd(numbers);
            break;
        case "GetSum":
            GetSum(numbers);
            break;
        case "Filter":
            FilterMethod(numbers, condition, element);
            break;
    }
}

foreach (int number in numbers)
{
    Console.Write(number + " ");
}

