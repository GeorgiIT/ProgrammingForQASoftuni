namespace NestedLoops;

class NumberPyramid
{
    static void Main_(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                counter++;
                Console.Write($"{counter} ");
                if(counter >= n)
                {
                    break;
                }
            }
            Console.WriteLine();
            if(counter >= n)
            {
                break;
            }
            
        }
    }
}

