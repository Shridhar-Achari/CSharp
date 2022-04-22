using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_25
{
    public class Generics<T>
    {
        /// <summary>
        /// Addition
        /// </summary>
        public T Addition(T a,T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            dynamic sum = n1 + n2;
            return sum;
        }
        /// <summary>
        /// Addition
        /// </summary>
        public T Subtraction(T a, T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            dynamic diff = n1 - n2;
            return diff;
        }
        /// <summary>
        ///  Multiplication
        /// </summary>
        public T Multiplication(T a, T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            dynamic prd = n1 * n2;
            return prd;
        }
        /// <summary>
        /// Division
        /// </summary>
        public T Division(T a, T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            dynamic quo = n1 / n2;
            return quo;
        }
    }
    public class Calculator
    {
        public static void Main()
        {
            Generics<int> gen = new Generics<int>();
            int res = gen.Addition(5, 5);
            Console.WriteLine("Sum is:"+res);
            int res1 = gen.Subtraction(5, 2);
            Console.WriteLine("Difference is:" + res1);
            int res2 = gen.Multiplication(5, 5);
            Console.WriteLine("Product is:" + res2);
            Generics<double> gen1 = new Generics<double>();
            double res3 = gen1.Division(10,3);
            Console.WriteLine("Quotient is:" + res3);

        }
    }  
}

