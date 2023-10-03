using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsSimpleLab
{
    internal class LatinLetters
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());

            for (char letter = letterOne; letter <= letterTwo; letter++) 
            {
                Console.Write(letter + " ");
            }

        }
    }
}
