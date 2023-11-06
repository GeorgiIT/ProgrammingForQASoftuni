namespace NestedLoops;

class TravelSavings
{
    static void Main_(string[] args)
    {
        while(true)
        {
            string destinationName = Console.ReadLine();
            if(destinationName == "End")
            {
                break;
            }
            float neededSum = float.Parse(Console.ReadLine());

            double sum = 0;

            while (sum < neededSum)
            {
                float command = int.Parse(Console.ReadLine());
                sum += command;
                Console.WriteLine($"Collected: {sum:f2}");
            }
            Console.WriteLine($"Going to {destinationName}!");
        }



        
    }
}

