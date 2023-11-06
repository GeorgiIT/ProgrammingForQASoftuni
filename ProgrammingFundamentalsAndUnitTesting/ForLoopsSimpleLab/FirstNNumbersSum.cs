using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsSimpleLab
{
    internal class FirstNNumbersSum
    {
        static void Main_(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++) 
            {
                sum += i;
                if(n == i)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + "+");
                }
                
            }
            Console.Write("=" + sum);
        }
    }
}
