namespace LoopsExercise;

class BiggestNum
{
    static void Main_(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var biggestNum = int.MinValue;
        
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if(number > biggestNum)
            {
                biggestNum = number;
            }
        }
        Console.WriteLine(biggestNum);
        
    }
}

