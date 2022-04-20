using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_23
{
    internal class ClassTask
    {
        public static void Student_Details(params int[] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************");
        }
        public static void Main()
        {
            Console.WriteLine();
        }
    }
}
