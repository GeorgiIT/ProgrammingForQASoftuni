using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsSimpleLab
{
    internal class NumbersEndingOn7
    {
        static void Main_(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) 
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
