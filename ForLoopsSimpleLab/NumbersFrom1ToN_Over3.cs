using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsSimpleLab
{
    internal class NumbersFrom1ToN_Over3
    {
        static void Main_(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
