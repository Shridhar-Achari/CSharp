using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task_22
{
    internal class Strings1
    {
        public static void Main()
        {
            Str_Method();
            Str_Builder_Method();
        }
      
        public static void Str_Method()
        {
            Console.WriteLine("3. Explore and show the working of the various methods and properties in Strings.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***String Method***\n");
            Console.ForegroundColor = ConsoleColor.White;
            string name = "John123";
            string course = "C# Programming";
            Console.WriteLine("Name is:{0}", name);
            Console.WriteLine("Course is:{0}", course);

            //character array
            char[] designation = { 'A', 'D', 'M', 'I', 'N' };
            //Pass the character array to String Class
            String des = new String(designation);
            Console.WriteLine("Designation passed to String class:{0}", des);
            

            //Access character array using foreach loop
            foreach (char desig in designation)
            {
                Console.Write(desig); //ADMIN
            }
            Console.WriteLine();

            //Escape Sequence characters
            //\n-new line
            Console.WriteLine("Welcome to C# Programming\nHave a Nice Day!!!");
            //\t-tab space
            Console.WriteLine("Welcome to C# Programming\tHave a Nice Day!!!");
            //\" \'
            Console.WriteLine("\"Welcome to C# Programming\"\n\'Have a Nice Day!!!\'");
            // \\
            Console.WriteLine("\\\\CSharp\\Strings");
            //Verbatim Strings
            Console.WriteLine(@"\\CSharp\Strings");

        }
        /// <summary>
        /// String Builder
        /// </summary>
        public static void Str_Builder_Method()
        {
            Console.WriteLine("3. Explore and show the working of the various methods and properties in String Builder.");
            Console.WriteLine("***String Builder***");
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb.ToString());
            //Append
            sb.Append("Good Morning");
            Console.WriteLine(sb.ToString());
            //AppendLine
            sb.AppendLine("How Are you");
            Console.WriteLine(sb.ToString());
            //Insert
            sb.Insert(17,"Have a nice day");
            Console.WriteLine(sb.ToString());
            //Remove
            sb.Remove(32,11);
            Console.WriteLine(sb.ToString());
        }
    }
}
