using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_26
{
    
    public class Delegate1
    {
        //Single-cast delegate
        public delegate void Addition(int a, int b);
        public delegate void Subtraction(int a, int b);
        public delegate void Multiplication(int a, int b);
        public delegate void Division(double a, double b);

        //Multi-cast delegate
        public delegate void Rectangle(double h, double w);
        
        //Single-cast delegate
        public void Sum(int a, int b)
        {
            Console.WriteLine("\nSum is:{0} \t",a + b);
        }
        public void Diff(int a, int b)
        {
            Console.WriteLine("\nDifference is:{0} \t", a - b);
        }
        public void Prd(int a, int b)
        {
            Console.WriteLine("\nProduct is:{0} \t", a * b);
        }
        public void Quo(double a, double b)
        {
            Console.WriteLine("\nQuotient is:{0} \t", a / b);
        }

        //Multi-cast delegate
        public void Area(double h, double w)
        {
            Console.WriteLine("\nArea of Rectangle is:{0} \t", h * w);
        }
        public void Perimeter(double h, double w)
        {
            Console.WriteLine("\nPerimeter of Rectangle is:{0} \t",2*(h+w));
        }


        public class Delegate2
        {
            public static void Main()
            {
                Console.WriteLine("2. Show the working of Multi-cast delegate.");
                //Instance for the class
                Delegate1 del1 = new Delegate1();
                //instance for the delegate1
                //Single-cast delegate
                Console.WriteLine("*******Single-cast delegate");
                Addition add = del1.Sum;//reference of the Add method 
                add(10, 10);
                Subtraction sub = del1.Diff;
                sub(15, 5);
                Multiplication mul = del1.Prd;
                mul(10, 10);
                Division div = del1.Quo;
                // div(15, 5); //or
                div.Invoke(10, 3);

                Console.WriteLine("\n*******Multi-cast delegate");
                //Multi-cast delegate
                Rectangle rect = del1.Area;//reference of the Area method 
                rect(5, 10);
                Rectangle rect1 = del1.Perimeter;//reference of the Perimeter method 
                rect1.Invoke(5, 4);
                Console.WriteLine("\n*******Creating Reference(Perimeter)");
                rect += del1.Perimeter;  //create reference
                rect(3, 4);      //it display both area and perimeter
                Console.WriteLine("\n*******Creating Reference(Area)");
                rect1 += del1.Area;  //create reference
                rect(5, 7);     //it display both area and perimeter


                Console.WriteLine("\n*******Removing Reference(Area)");
                rect1 -= del1.Area; //remove reference
                rect1(6, 4); //it only display prrimeter
            }
        }
    }
}
