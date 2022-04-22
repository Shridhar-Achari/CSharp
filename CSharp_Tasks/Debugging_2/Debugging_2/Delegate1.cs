using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int NumberChanger(int n);//return type int
namespace Debugging_2
{
    
    class TestDelegate
    {

        public static int num = 1;  //Missing Semi colon
        public static int AddNum(int p)
        {
                num += p;
                return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num; //missing return & closing brace
        }
        public static int getNum()
        {
             return num;
        }
        public static void Main(string[] args)//access specifier
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

             //calling the methods using the delegate objects
            nc1(25);
             Console.WriteLine("Value of Num: {0}", getNum());
            nc2(3); //declare 
            Console.WriteLine("Value of Num: {0}", getNum());
             Console.ReadKey();
        }
    }

}
