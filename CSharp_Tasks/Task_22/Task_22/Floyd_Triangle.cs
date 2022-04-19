using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class Floyd_Triangle
    {
        public static void Main()
        {
            ///2. Write a program to print Floyd Triangle.
            ///Pattern
            ///------------
            ///1
            ///2 3
            ///4 5 6 
            int n,k=1;
            Console.WriteLine("2. Write a program to print Floyd Triangle.");
            Console.WriteLine("***Floyd Triangle Pattern***\n");
            Console.WriteLine("Enter the value for n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(k++ + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
