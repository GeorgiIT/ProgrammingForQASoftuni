using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsLab
{
    internal class NumberProcessor
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while(true) 
            {
                string commant = Console.ReadLine();
                if (commant == "End")
                {
                    Console.WriteLine(num);
                    break;
                }
                else if (commant == "Inc")
                {
                    num += 1;
                }
                else if (commant == "Dec")
                {
                    num -= 1;
                }
            }
        }
    }
}
