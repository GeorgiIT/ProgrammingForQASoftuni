using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArraysExercise
{
    internal class CommonElements
    {
        static void Main_(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            var commonElements = secondArray.Intersect(firstArray);

            
            foreach (var item in commonElements)
            {
                Console.Write(item + " ");
            }

        }
    }
}
