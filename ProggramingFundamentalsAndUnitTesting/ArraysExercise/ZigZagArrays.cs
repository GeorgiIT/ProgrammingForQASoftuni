using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    internal class ZigZagArrays
    {
        static void Main_(string[] args)
        {


            
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];
            bool hisTurn = true;

            for (int i = 0; i < n; i++)
            {
                
                string[] input = Console.ReadLine().Split(' ');


                if (hisTurn)
                {
                    array1[i] = int.Parse(input[0]);
                    array2[i] = int.Parse(input[1]);
                    hisTurn = false;
                }
                else
                {
                    array1[i] = int.Parse(input[1]);
                    array2[i] = int.Parse(input[0]);
                    hisTurn = true;
                }    
                
            }


            for (int i = 0; i < n; i++)
            {
                
                Console.Write(array1[i] + " ");
                   
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(array2[i] + " ");
            }

            

        }
    }
}


