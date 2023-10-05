using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsLab
{
    internal class SumDigits
    {
        static void Main_(string[] args)
        {
            string str = Console.ReadLine();
            
            string[] elements = str.ToCharArray().Select(c => c.ToString()).ToArray();

            

            int sum = elements.Select(int.Parse).Sum();
            Console.WriteLine(sum);

        }
    }
}
