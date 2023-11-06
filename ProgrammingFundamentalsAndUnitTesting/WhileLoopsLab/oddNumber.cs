namespace WhileLoopsLab
{
    internal class Program
    {
        static void Main_(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());


                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                    break;
                }
            }
        }
    }
}