using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsLab
{
    internal class NumberInRange
    {
        static void Main_(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if(num >= 1 && num <= 100)
                {
                    Console.WriteLine(num);
                    break;
                }
            }
        }
    }
}
