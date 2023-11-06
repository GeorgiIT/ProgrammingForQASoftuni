namespace LoopsExercise;

class PowerOfNum
{
    static void Main_(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int sum = 1;
        for (int i = 0; i <p; i++)
        {
            sum *= n;
        }
        Console.WriteLine(sum);
    }
}

