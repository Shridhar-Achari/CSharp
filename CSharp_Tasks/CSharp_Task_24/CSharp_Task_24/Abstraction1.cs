using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_24
{
    public abstract class Abstraction1
    {
        public abstract void addition();
     
    }
    public class Abstraction2:Abstraction1
    {
        public override void addition()
        {
            int a = 10;
            int b = 10;
            int c = a + b;
            Console.WriteLine("Sum is:" + c);

        }
        public static void Main()
        {
            Abstraction2 a = new Abstraction2();
            a.addition();
        }
    }
}
