using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_24
{
    internal class Hybrid_I
    {
		///<summary>
		///3. Show the working of Hybrid Inheritance
		/// </summary>
		internal class University
		{

			public void USN()
			{
				string usn;
				Console.WriteLine("(Base class)");
				Console.WriteLine("Student USN:");
				usn = Console.ReadLine();
			}

		}

		class College : University
		{

			public void Clg()
			{
				string cname;
				Console.WriteLine("(Derived class)");
				Console.WriteLine("Enter College Name:");
				cname = Console.ReadLine();
			}

			public void Lib()
			{
				int lid;
				Console.WriteLine("Enter Library Id:");
				lid = Convert.ToInt32(Console.ReadLine());
			}
		}

		// Inherit /derived / extends
		class Student1 : College
		{

			// Student1 constructor
			public void S1info()
			{
				string sname;
				Console.WriteLine("(Constructor)");
				Console.WriteLine("Enter Student Name");
				sname= Console.ReadLine();
			}
			public void S1display()
			{
				Console.WriteLine("***STUDENT DETAILS***");
			}
		}

		class Student2 : College
		{

			// Student2 constructor
			public void S2info()
			{
				string sname;
				Console.WriteLine("(Constructor)");
				Console.WriteLine("Enter Student Name");
				sname = Console.ReadLine();
			}
			public void S2display()
			{
				Console.WriteLine("***STUDENT DETAILS***");
			}
		}


		public static void Main()
        {
            Console.WriteLine("3. Show the working of Hybrid Inheritance");
			// Student1 object
			Student1 s1 = new Student1();
			s1.S1info();
			s1.USN();
			s1.Clg();
			s1.Lib(); 
			s1.S1display();
			Console.WriteLine("Details");

			// Student2 object
			Student2 s2 = new Student2();
			s2.S2info();
			s2.USN();
			s2.Clg();
			s2.Lib();
			s2.S2display();
		}
    }
}
