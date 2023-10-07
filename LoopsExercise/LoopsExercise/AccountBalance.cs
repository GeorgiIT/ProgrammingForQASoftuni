namespace LoopsExercise;

class AccountBalance
{
    static void Main(string[] args)
    {
        
        double balance = 0;
        while(true)
        {
            string command = Console.ReadLine();
            if (command == "End")
            {
                
                Console.WriteLine($"Balance: {balance:f2}");
                break;
            }
            double num = double.Parse(command);
            if(num > 0)
            {
                balance += num;
                Console.WriteLine($"Increase: {num:f2}");
            }
            else
            {
                balance -= Math.Abs(num);
                Console.WriteLine($"Decrease: {Math.Abs(num):f2}");
            }
            
        }

    }
}

