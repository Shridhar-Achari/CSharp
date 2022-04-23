using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_26
{
    internal class Catch1
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("4. Show the working of multiple catch.");
            Console.WriteLine("Enter the number of iterations to perform:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                try
                {
                    int n1, n2, n3;
                    Console.WriteLine("***Division****\n");
                    Console.Write("Enter the numerator:\t");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter the Denominator:\t");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = n1 / n2;
                    Console.Write("\nQuotient is:\t{0}", n3 + "\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nOverflow Exception!!!!!");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("\nIteration "+i+" is completed\n");
                }
            }
        }
    }
}
