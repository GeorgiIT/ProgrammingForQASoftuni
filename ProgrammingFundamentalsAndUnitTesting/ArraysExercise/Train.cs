namespace ArraysExercise
{
    internal class Train
    {
        static void Main_(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());

            int[] passangers = new int[vagons];

            for (int i = 0; i < vagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0;i < vagons; i++)
            {
                
                if (i == vagons - 1)
                {
                    Console.Write(passangers[i]);
                    break;
                }
                Console.Write(passangers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(passangers.Sum());
        }
    }
}