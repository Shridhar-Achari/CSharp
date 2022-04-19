using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class Matrix1
    {
        public static void Main()
        {
            Console.WriteLine("5. Write a program to perform matrix addition using 2D Arrays.");
            int i, j, n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];
            Console.WriteLine("***Addition of Two Matrix***\n");
            Console.WriteLine("Enter the sixe of the matrix:");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the values for Matrix1:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Position-[{0},{1}]:\t",i,j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nEnter the values for Matrix2:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Position-[{0},{1}]:\t", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //display
            Console.WriteLine("\nMatrix1 Elements are:");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t",arr1[i,j]);
                }
            }
            Console.WriteLine("\nMatrix2 Elements are:");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }

            //Addition
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr3[i, j] =arr1[i,j]+arr2[i,j];
                }
            }
            //display
            Console.WriteLine("\nAddtion of two matrix is:");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }
            }
        }
    }
}
