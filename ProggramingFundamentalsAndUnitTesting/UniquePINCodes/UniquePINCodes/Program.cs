int maxOne = int.Parse(Console.ReadLine());
int maxTwo = int.Parse(Console.ReadLine());
int maxThree = int.Parse(Console.ReadLine());

for (int i = 1; i <= maxOne; i++)
{
    for (int j = 1; j <= maxTwo; j++)
    {
        for (int k = 1; k <= maxThree; k++)
        {
            if(i % 2 == 0 && k % 2 == 0)
            {
                if(j == 2 || j == 3 || j == 5 || j == 7)
                {
                    Console.WriteLine($"{i}{j}{k}");
                }
                
            }
        }
    }
}