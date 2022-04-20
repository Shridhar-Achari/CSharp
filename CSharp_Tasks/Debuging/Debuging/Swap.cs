using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuging
{
    internal class Swap //Delcare class
    {
        public static void Main()
        {
            int a=6, b=8; ///Initialize the value for a and b example a=6, b=8 
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            b = a / b; //b=a/b;
            a = a / b;
            Console.Write("After swap a= " + a + " b= " + b); //”After swap a=”+a+ and “b=”+b
        }

    }
}
