static void MultiplicationWhithOutMultiplication(int num1, int num2, int num3)
{

    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if (num1 < 0 || num2 < 0 || num3 < 0)
    {
        if ((num1 < 0 && num2 < 0) || (num3 < 0 && num2 < 0) || (num1 < 0 && num3 < 0))
        {
            Console.WriteLine("positive");

        }
        else
        {
            Console.WriteLine("negative");
        }

    }
    else if (num1 > 0 || num2 > 0 || num3 > 0)
    {
        Console.WriteLine("positive");
    }

}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

MultiplicationWhithOutMultiplication(num1, num2, num3);
