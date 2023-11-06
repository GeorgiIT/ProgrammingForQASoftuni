static int GetMax(int num1, int num2,int num3)
{
    int biggestNum = int.MinValue;
    if (num1 > num2 && num1 >= num3)
    {
        biggestNum = num1;
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        biggestNum = num2;
    }
    else if (num3 >= num2 && num3 >= num1)
    {
        biggestNum = num3;
    }
    return biggestNum;
}

int num1 = int.Parse(Console.ReadLine());
int num2  = int.Parse(Console.ReadLine());
int num3  = int.Parse(Console.ReadLine());

Console.WriteLine(GetMax(num1, num2, num3));