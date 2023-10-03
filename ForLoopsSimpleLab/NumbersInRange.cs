namespace ForLoopsSimpleLab
{
    internal class NumbersInRange
    {
        static void Main_(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}