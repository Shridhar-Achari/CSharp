using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_24
{
    public abstract class Electricity
    {
        protected double rate;
        public abstract void Get_Price();
        public void calculate(int units)
        {
            Console.Write("Bill amount for "+units+" units is: Rs.");
            Console.WriteLine(rate*units);
        }
    }
    class Rural:Electricity
    {
        public override void Get_Price()
        {
            rate = 4.50;
        }
    }
    class Urban : Electricity
    {
        public override void Get_Price()
        {
            rate = 7.50;
        }
    }
    //Main
    public class Abstraction
    {
        ///<summary>
        ///1. Calculate Electricity Bill using Abstraction
        ///2. Show the working of 2 Interfaces(interface1(area()),interface2(perimeter()))
        ///3. Show the working of Hybrid Inheritance
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("1. Calculate Electricity Bill using Abstraction");
            Console.WriteLine("***Electricity Bill Details***");

            Electricity ele;            
            Console.WriteLine("\nRural Connection:");
            ele = new Rural();
            ele.Get_Price();
            ele.calculate(100);
            Console.WriteLine("\nUrban Connection:");
            ele = new Urban();
            ele.Get_Price();
            ele.calculate(100);
        }
    }
}


