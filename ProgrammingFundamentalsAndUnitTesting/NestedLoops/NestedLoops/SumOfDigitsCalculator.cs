namespace NestedLoops;

class SumOfDigitsCalculator
{
    static void Main_(string[] args)
    {
        while(true)
        {
            string number = Console.ReadLine();
            if(number == "End")
            {
                Console.WriteLine("Goodbye"); 
                break;
            }
            
            Console.WriteLine($"Sum of digits = {SumOfDigitsGenerator(number)}");
            



        }
    
    }
    static int SumOfDigitsGenerator(string number)
    {
        int sum = 0;
        foreach(char digitChar in number)
        {
            if(char.IsDigit(digitChar))
            {
                int digit = int.Parse(digitChar.ToString());
                sum += digit;
            }
            else
            {
                Console.WriteLine($"Ignoring non-digit character: {digitChar}");
            }
        }

        return sum;
    }
}

