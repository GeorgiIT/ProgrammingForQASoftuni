using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsLab
{
    internal class Sequince2k
    {
        static void Main_(string[] args)
        {
            
            
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int firstNum = 1;
            while (true)
            {
                Console.WriteLine(firstNum);
                firstNum = firstNum + (counter * 2);
                counter = counter * 2;
                if (firstNum > n)
                {
                    break;
                }    
            }    
        }
    }
}
