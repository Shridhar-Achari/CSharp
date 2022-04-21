using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_24
{
    ///<summary>
    ///2. Show the working of 2 Interfaces(interface1(area()),interface2(perimeter()))
    /// </summary>
    public interface Interface1
    {
        void Area();
    }
    public interface Interface2
    {
        void Perimeter();
    }
    /// <summary>
    /// Interfaces is implementing Interface1,Interface2
    /// </summary>
    public class Interfaces: Interface1, Interface2
    {
        void Interface1.Area()
        {
            double b, h, area;
            Console.WriteLine("***Area of Triangle***");
            Console.WriteLine("Enter the base:");
            b =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            h =Convert.ToInt32(Console.ReadLine());
            area = (b * h) / 2;
            Console.Write("Area of triangle is: " + area);
        }
        void Interface2.Perimeter()
        {
            double s1, s2, s3, perimeter;
            Console.WriteLine("\n\n***Perimeter of Triangle***");
            Console.WriteLine("Enter the value for side1:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for side2:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for side3:");
            s3 = Convert.ToInt32(Console.ReadLine());
            perimeter = s1+s2+s3;
            Console.Write("Perimeter of triangle is: " + perimeter+"\n\n");
        }
    }
    /// <summary>
    /// Base to Derived
    /// </summary>
    public class Inter_area_peri
    {
        public static void Main()
        {
            Console.WriteLine("2. Show the working of 2 Interfaces(interface1(area()),interface2(perimeter()))");
            Interface1 inter1=new Interfaces();
            inter1.Area();
            Interface2 inter2=new Interfaces(); 
            inter2.Perimeter();
        }
    }
}
