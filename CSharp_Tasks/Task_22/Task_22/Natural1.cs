using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class Natural1
    {
        public static void Main()
        {
            ///<summary>
            ///4. Write a program to calculate the sum of naturals numbers using 1D Array(get the size of the array and input from the user).
            /// </summary>
            Console.WriteLine("4. Write a program to calculate the sum of naturals numbers using 1D Array(get the size of the array and input from the user).");
            Console.WriteLine("***Sum of Natural Numbers***");
            int size,sum=0;
            Console.WriteLine("Enter the size of the array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            //Get the input from the user for the array arr
            for (int i = 0; i < arr.Length; i++)
            { 
                Console.WriteLine("Enter the value for {0}:",(i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
                {
                    sum=sum+arr[i];
                }
            }
            //Display the elements in the array arr
            Console.WriteLine("Sum of natural numbers:");
            {
                Console.WriteLine(sum);
            }
        }
    }
}
