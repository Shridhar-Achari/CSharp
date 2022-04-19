using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class JArray1
    {
        public static void Main()
        {
            int[][] jagged = new int[4][]
            {
                new int[3]{45,67,76},
                new int[5]{54,78,56,96,78},
                new int[4]{54,37,26,97},
                new int[2]{97,89}
            };
            Console.WriteLine("7. Write a program to show the working of 1D Jagged array.");
            Console.WriteLine("Elements in the Jagged Array are:");
            for(int i=0;i<jagged.Length;i++)
            {
                for (int j = 0; j<jagged[i].Length;j++)
                {
                    Console.Write(jagged[i][j]+"\t");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
