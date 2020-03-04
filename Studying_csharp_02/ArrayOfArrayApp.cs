using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class ArrayOfArrayApp
    {
        public static void Main()
        {
            int[][] arrayOfarray = new int[3][];
            int i, j;
            for (i = 0; i < arrayOfarray.Length; i++)
            {
                arrayOfarray[i] = new int[i + 3];
            }
            for (i = 0; i < arrayOfarray.Length; i++)
            {
                for (j = 0; j < arrayOfarray[i].Length; j++)
                {
                    arrayOfarray[i][j] = i * arrayOfarray[i].Length + j;
                }

            }
            for (i = 0; i < arrayOfarray.Length; i++)
            {
                for (j = 0; j < arrayOfarray[i].Length; j++)
                {
                    Console.WriteLine(" " + arrayOfarray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
