static void MagicNumber(int number)
{
    for (int a = 0; a <= 9; a++)
    {
        for (int b = 0; b <= 9; b++)
        {
            for (int c = 0; c <= 9; c++)
            {
                if(a * b * c == number)
                {
                    Console.Write($"{a}{b}{c} ");
                }
                
            }
        }
        
    }
}

int n = int.Parse(Console.ReadLine());
MagicNumber(n);