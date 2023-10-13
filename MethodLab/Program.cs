static void RepeatString(int num, int power)
{
    int sum = 1;
    for (int i = 0; i < power; i++)
    {
        sum *= num;
    }
    Console.WriteLine(sum);
}

int num = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

RepeatString(num, power);