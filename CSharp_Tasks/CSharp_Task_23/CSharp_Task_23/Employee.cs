using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_23
{
    internal class Employee
    {
        public static void Main()
        {
            int i, n;
            Console.WriteLine("Enter number of employees:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                int Empid;
                String Ename, Dept;
                Console.WriteLine("Enter Emp id:");
                Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Emp Name:");
                Ename = Console.ReadLine();
                Console.WriteLine("Enter Emp Dept:");
                Dept = Console.ReadLine();
            }
        }
    }
}
