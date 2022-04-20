using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_23
{
    public class Area
    {
        public static void Area1(int a)
        {  
            int Area = a * a;
            Console.WriteLine(Area);
        }
        public static void Area1(int a,int b)
        {
            int Area = a * b;
            Console.WriteLine(Area);
        }
        class Program
        {

            public static void Main()
            {
                Area1(5);
                Area1(5, 7);
            }
        }
    }
}
