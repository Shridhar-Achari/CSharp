using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_23
{
    internal class Nullable
    {
        public static void Main()
        {
            Console.WriteLine("2. Show the working of Nullables with various datatype.");
            ///<summary>
            ///Nullable ?-After datatype (datatype ? variable name=null;)or 
            ///Nullable<datatype>variable name=null;
            /// These are value type and can accept null values.
            /// </summary>
            int? n1 = null;
            String? name = null;
            double? mark=null;
            float? perc=null;
            Nullable<char> grade = null;

            if (n1.HasValue)
            {
                Console.WriteLine("n1.value");
            }
            else
            {
                Console.WriteLine("n1 value is null");
            }
        
            Console.Write("Null values are:"+n1+"\n"+name + "\n"+mark + "\n" + perc + "\n" + grade + "\n");

            Console.WriteLine("3. Show the working of NULL COALESCING OPERATOR ??");
            ///<summary>
            ///Null Coalescing Operator(??) replace null value with actual value
            /// </summary>
            int? num1 = null;
            int? num2 = 5000;
            int? res = num1 ?? num2;
            Console.WriteLine("The value of num1 is:{0}\t", num1);
            Console.WriteLine("The value of num2 is:{0}\t", num2);
            Console.WriteLine("The value of res is:{0}\t", res);
            String? menu1 = null;
            String? menu2= null;
            String? menu3= "Masalapuri";
            String? final;
            final = menu1 ?? menu2 ?? menu3;
            Console.WriteLine("\nI want "+final);
        }
    }
}
