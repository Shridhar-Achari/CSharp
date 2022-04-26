using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_27
{
    internal class PassVRO
    {
        public class Circle
        {
            public static void Main()
            {
                Console.WriteLine(" Explore the difference between pass by value, pass by reference(ref keyword) and pass by out(out keyword) in C#.");
                Console.WriteLine("Enter the radius:");
                double radius = Convert.ToDouble(Console.ReadLine());
                double perimeter = CalculateCircle(radius, out double area);
                
                Console.WriteLine($"Perimeter of circle is: {perimeter}");
                Console.WriteLine($"Area of circle is:{area}");
                Console.WriteLine("Value after pass by, Radius is:",radius);
                Console.ReadKey();
            }
            public static double CalculateCircle(double radius, out double area)
            {
                area = Math.PI * Math.Pow(radius, 2);
                double perimeter= 2 * Math.PI * radius;
                return perimeter;
            }
        }
    }
}