static double FactorialDevision(int a, int b)
{
    int resultA = 1;
    int resultB = 1;

    for (int i = a; i > 0; i--)
    {
        resultA *= i;
    }

    for (int i = b; i > 0; i--)
    {
        resultB *= i;
    }
    double sum = resultA / resultB;
    return sum;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

double result = FactorialDevision(a, b);
Console.WriteLine(result);
