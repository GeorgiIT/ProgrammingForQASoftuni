using System.Diagnostics.Metrics;

namespace LoopsExercise;

class Devision
{
    static void Main_(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        int twoCounter = 0;
        int threeCounter = 0;
        int fourCounter = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                twoCounter++;
            }
            if (number % 3 == 0)
            {
                threeCounter++;
            }
            if (number % 4 == 0)
            {
                fourCounter++;
            }
        }

        double percentTwo = twoCounter * 1.0 / n * 100;
        double percentThree = threeCounter * 1.0 / n * 100;
        double percentFour = fourCounter * 1.0 / n * 100;

        Console.WriteLine($"{percentTwo:f2}%");
        Console.WriteLine($"{percentThree:f2}%");
        Console.WriteLine($"{percentFour:f2}%");

    }
}

