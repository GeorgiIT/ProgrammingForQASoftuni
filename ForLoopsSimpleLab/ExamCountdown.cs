using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsSimpleLab
{
    internal class ExamCountdown
    {
        static void Main_(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            for (int i = days; i >= 0; i--)
            {
                
                if (i == 0)
                {
                    Console.WriteLine("The exam has come");
                }
                else
                {
                    Console.WriteLine($"{i} days before the exam");
                }
            }
        }
    }
}
