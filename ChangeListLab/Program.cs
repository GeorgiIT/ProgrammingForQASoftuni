List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();
int element = 0;
int position = 0;

while(true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        break;
    }
    List<string> commands = new List<string>(command.Split(" "));
    if (commands.Count > 2 ) 
    {
        element = int.Parse(commands[1]);
        position = int.Parse(commands[2]);
    }
    else
    {
        element = int.Parse(commands[1]);
    }

    switch (commands[0]) 
    {
        case "Delete":
            numbers.RemoveAll(number => number == element); 
            break;
        case "Insert":
            numbers.Insert(position, element);
            break;
    }
}

foreach (var item in numbers)
{
    Console.Write(item + " ");
}