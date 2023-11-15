string[] words = Console.ReadLine().Split(" ").ToArray();
Dictionary<string, int> wordsCount = new();

foreach (var word in words)
{
    string lowerWord = word.ToLower();
    if(wordsCount.ContainsKey(lowerWord))
    {
        wordsCount[lowerWord] += 1;
    }
    else 
    { 
        wordsCount.Add(lowerWord, 1 );
    }
}

foreach (var pair in wordsCount)
{
    if(pair.Value % 2 != 0)
    {
        Console.Write(pair.Key + " ");
    }
}