namespace LoopsExercise;

class SpecialNumber
{
    static bool IsSpecialNumber(int num)
    {
        // Convert the number to a string to access its digits
        string numStr = num.ToString();

        foreach (char digitChar in numStr)
        {
            int digit = int.Parse(digitChar.ToString());

            // Check if the digit is not zero and the number is not divisible by the digit
            if (digit == 0 || num % digit != 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main_()
    {
        
        int num = int.Parse(Console.ReadLine());

        if (IsSpecialNumber(num))
        {
            Console.WriteLine($"{num} is special");
        }
        else
        {
            Console.WriteLine($"{num} is not special");
        }
    }
}


