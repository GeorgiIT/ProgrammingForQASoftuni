namespace NestedLoops;

class Building
{
    static void Main_(string[] args)
    {
        int floors = int.Parse(Console.ReadLine());
        int estates = int.Parse(Console.ReadLine());

        for (int i = floors; i >= 1 ; i--)
        {
            for (int j = 0; j < estates; j++)
            {
                if (i == floors)
                {
                    Console.Write($"L{i}{j} ");
                }
                else if (i % 2 == 0)
                {
                    Console.Write($"O{i}{j} ");

                }
                else if(i % 2 != 0)
                {
                    Console.Write($"A{i}{j} ");
                }
            }
            Console.WriteLine();
        }
    }
}

