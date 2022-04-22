using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ErrorHandlingApplication
{
    
    class DivNumbers
    {
        int result;//initialize int 
        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException  e)//declare variable e
            {
                Console.WriteLine("Exception caught:{0} ",e);//missing string formatter
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        public static void Main()
        {
            DivNumbers d = new DivNumbers();
            d.division(5,0);//value within the parameter if we give one parameter 0 then it will handle the exception
            Console.ReadKey();
        }
    }
}

