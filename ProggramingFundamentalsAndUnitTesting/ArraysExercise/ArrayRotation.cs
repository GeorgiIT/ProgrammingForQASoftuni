using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    internal class ArrayRotation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            Console.WriteLine("Enter the number of rotations:");
            int rotations = int.Parse(Console.ReadLine());

            RotateArray(elements, rotations);

            Console.WriteLine("Array after rotating:");
            Console.WriteLine(string.Join(" ", elements));
        }

        static void RotateArray(string[] arr, int rotations)
        {
            int length = arr.Length;

            // Ensure rotations is within the length of the array
            rotations = rotations % length;

            string[] temp = new string[rotations];

            // Copy the first 'rotations' elements to the temporary array
            for (int i = 0; i < rotations; i++)
            {
                temp[i] = arr[i];
            }

            // Shift the remaining elements to the front
            for (int i = rotations; i < length; i++)
            {
                arr[i - rotations] = arr[i];
            }

            // Copy the temporary array to the back of the original array
            for (int i = length - rotations, j = 0; i < length; i++, j++)
            {
                arr[i] = temp[j];
            }
        }
    }
}
