using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_27
{
    internal class Dispose1
    {
        public class DestDispose : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("***Memory is Cleared**");
            }
        }
        internal class ConstructorDestructor
        {
            public static void Main()
            {
                Calculator c=new Calculator();
                Calculator calculator = new Calculator();//Default Constructor is called
                Calculator calculator1 = new Calculator(c.v1,c.v2,c.v3);//Constructor (1 int parameter)
                Calculator calculator2 = new Calculator(c.v1, c.v2);//Constructor (2 int parameters)
                DestDispose destDispose = new DestDispose();
                destDispose.Dispose();
            }
        }
        public class Calculator
        {
            public int v1, v2,v3;
            public Calculator()
            {
                Console.WriteLine("***Calculator***");
            }
            
            public Calculator(int a, int b, int c)
            {
                Console.WriteLine("Addition");
                Console.WriteLine("value1:");
                v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value2:");
                v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value3:");
                v3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(v1 + v2+ v3);
            }

            public Calculator(int v1, int v2)
            {
                
                Console.WriteLine("Multiplication");
                Console.WriteLine("value1:");
                v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("value2:");
                v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(v1*v2);
            }
            ~Calculator()
            {
                Console.WriteLine("Calculation Complete");
            }

        }
    }
}
