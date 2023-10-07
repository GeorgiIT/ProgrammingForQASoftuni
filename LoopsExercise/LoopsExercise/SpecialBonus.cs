namespace LoopsExercise;

class SpecialBonus
{
    static void Main_(string[] args)
    {


        int num = int.Parse(Console.ReadLine());
        double lastNum = num;
        while(true)
        {

            int n = int.Parse(Console.ReadLine());
            if (n == num)
            {
                break;
            }
            lastNum = n;
        }
        Console.WriteLine(lastNum * 1.2);
        

    }
}

