static void TriangleLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void TriangleStructure(int number)
{
    for (int i = 1; i <= number; i++)
    {
        TriangleLine(1, i);
    }
    for (int i = number - 1; i > 0; i--)
    {
        TriangleLine(1, i);
    }
}


int n = int.Parse(Console.ReadLine());
TriangleStructure(n);