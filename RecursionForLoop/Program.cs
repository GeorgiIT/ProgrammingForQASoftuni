static void RecursionLoop(int n)
{
    int num1 = 1;
    int num2 = 1;
    int num3 = 1;
    if (num1 <= n)
    {
        if (num2 <= n)
        {
            if (num3 <= n)
            {
                Console.Write(num1 + " " + num2 + " " + num3 );
                num3++;
                RecursionLoop(n);
            }
            else if (num3 == n)
            {
                Console.Write(num1 + " " + num2 + " " + num3);
                num2++;
                RecursionLoop(n);
            }
            else if (num2 == n)
            {
                Console.Write(num1 + " " + num2 + " " + num3);
                num1++;
                RecursionLoop(n);
            }
            
        }
        
    }    
}


int n = int.Parse(Console.ReadLine());
RecursionLoop(n);