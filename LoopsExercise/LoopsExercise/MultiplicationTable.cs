namespace LoopsExercise;

class MultiplicationTable
{
    static void Main_(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        

        
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n*i}");
        }
        
    }
}

