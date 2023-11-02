using System.Security;

int num = int.Parse(Console.ReadLine());



for (int i = 1; i <= num; i++)
{
    bool isPrime = true;
    int currentNum = i;
    int digitSum = 0;

    while(currentNum > 0)
    {
        int digit = currentNum % 10;
        currentNum = currentNum / 10;

        if (digit == 2 || digit == 3 || digit == 5 || digit == 7)
        {
            digitSum += digit;
        }
        else
        {
            isPrime = false;
            break;
        }
        
        
    }
    if(isPrime && digitSum % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
