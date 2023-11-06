    int result = int.Parse(Console.ReadLine());
    int sum = 0;
    while(result != 0)
    {
        int digit = result % 10;
        result = result / 10;

        if (digit % 2  == 0)
        {
            sum += CalculateFactorial(digit);
        }
    }

    Console.WriteLine(sum);

    int CalculateFactorial(int number)
    {
        int result = 1;
        while (number > 0)
        {
            result = result * number;
            number -= 1;
        }
        return result;

    }