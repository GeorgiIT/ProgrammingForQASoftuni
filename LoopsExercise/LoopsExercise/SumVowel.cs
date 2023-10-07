namespace LoopsExercise;

class SumVowel
{
    static void Main(string[] args)
    {

        int a = 1;
        int e = 2;
        int i = 3;
        int o = 4;
        int u = 5;

        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int num = 0; num < n; num++)
        {
            string commant = Console.ReadLine();

            switch (commant)
            {
                case "a":
                    sum += a;
                    break;
                case "e":
                    sum += e;
                    break;
                case "i":
                    sum += i;
                    break;
                case "o":
                    sum += o;
                    break;
                case "u":
                    sum += u;
                    break;

            }

        }
        Console.WriteLine(sum);

    }
}

