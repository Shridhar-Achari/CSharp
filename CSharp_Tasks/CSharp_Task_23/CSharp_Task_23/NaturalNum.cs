using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_23
{
    public class NaturalNum
    {
        public static void Natural(params int[] arr)
        {
            Console.WriteLine("4. Write a program to perform sum of natural numbers using params array.");
            Console.WriteLine("***Sum of Natural Numbers***");
            int n, sum = 0;
            Console.WriteLine("Enter the size of the array");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            //Get the input from the user for the array arr
            for (int i = 1; i <=arr.Length; i++)
            {
                Console.WriteLine("Natural numbers are:"+i);
                sum += i;
            }
            Console.WriteLine("Sum of "+n+" natuaral Numvers is:" + sum);
        }
        public static void Main()
        {
           Natural();
        }
    }
}
