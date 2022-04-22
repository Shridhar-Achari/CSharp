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
            string ans;
            int n1=0, n2=0;
            do
            {
                Generics<int> gen = new Generics<int>();
                Generics<double> gen1 = new Generics<double>();
                Console.WriteLine("\n**** Calculator ***\n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                        Console.WriteLine("\nEnter first number:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        int res = gen.Addition(n1, n2);
                        Console.WriteLine("Sum is:" + res);
                        break;
                    case 2:
                        Console.WriteLine("\nEnter first number:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        int res1 = gen.Subtraction(n1,n2);
                        Console.WriteLine("Difference is:" + res1);
                        break;
                    case 3:
                        Console.WriteLine("\nEnter first number:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        int res2 = gen.Multiplication(n1,n2);
                        Console.WriteLine("Product is:" + res2);
                        break;
                    case 4:
                        Console.WriteLine("\nEnter first number:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        double res3 = gen1.Division(n1,n2);
                        Console.WriteLine("Quotient is:" + res3);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("_________________________\n");
                Console.Write("Do you want to continue(yes/no):");
                ans = Console.ReadLine();
            }
            while (ans == "yes");
        }
    }  
}

