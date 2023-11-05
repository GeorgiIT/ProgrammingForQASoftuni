List<int> initialQuality = new List<int> { 10, 12, 13 };
List<string> commands = new List<string> { "Hit it again, Gabsy!", "Hit it again, Gabsy!", "Hit it again, Gabsy!" };
decimal money = 1;

Console.WriteLine(Drum(money, initialQuality, commands));

static string Drum(decimal money, List<int> initialQuality, List<string> commands)
{ 

List<int> usedQuality = initialQuality.ToList();

foreach (string command in commands)
{
    if (command == "Hit it again, Gabsy!")
    {
        return $"{string.Join(" ", usedQuality)}\nGabsy has {money:f2}lv.";
    }

    bool isParsed = int.TryParse(command, out int power);
    if (!isParsed)
    {
        throw new ArgumentException("Number did not parse correctly!");
    }

    for (int i = 0; i < usedQuality.Count; i++)
    {
        usedQuality[i] -= power;
        if (usedQuality[i] > 0)
        {
            continue;
        }

        int price = initialQuality[i] * 3;
        if (money - price > 0)
        {
            money -= price;
            usedQuality[i] = initialQuality[i];
        }
        else if (money - price <= 0)
        {
            initialQuality.RemoveAt(i);
            usedQuality.RemoveAt(i);
            i--;
        }
    }
}

throw new ArgumentException("Terminate command not given!");
}