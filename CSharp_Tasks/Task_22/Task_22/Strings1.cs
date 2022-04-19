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
            Console.WriteLine("\n***Background color(Red)***");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n***String Method***\n");
            Console.WriteLine("\n***Foreground color(Blue)***");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = "Shridhar";
            string group = "MARS";
            Console.WriteLine("Name is:{0}", name);
            Console.WriteLine("Course is:{0}", group);
            //length
            Console.WriteLine("\n***Length of the String***");
            string str = "BootCamp";
            Console.WriteLine("String is"+str);
            int length = str.Length;
            Console.WriteLine("Length is:" + length);

            //Concatenation
            Console.WriteLine("\n***Concatenating of the 2 Strings***");
            string str1 = "DLithe";
            Console.WriteLine("String 1 is:"+str1);
            string str2 = "BootCamp";
            Console.WriteLine("String 2 is:" + str2);
            string add =string.Concat(str1, str2);
            Console.WriteLine("Joined String is:"+add);

            //character array
            Console.WriteLine("\n***Characater Array***");
            char[] Training = { 'B','O','O','T',' ','C','A','M','P' };
            //Pass the character array to String Class
            String train = new String(Training);
            Console.WriteLine("Character from Training passed to String class:{0}", train);

            //Escape Sequence characters
            Console.WriteLine("\n***-Escape Sequence characters-***");
            //\n-new line
            Console.WriteLine(@"***New Line (\n)***");
            Console.WriteLine("Studenet Database\nDetails Of the Students\n");
            //\t-tab space
            Console.WriteLine("\n***Tab space***\n");
            Console.WriteLine("Student Id\tStudent Name\tTotal Mark\tPercentage\n\n");
            //\"
            Console.WriteLine("\n***Use of slash double quotation to print double quotation***\n");
            Console.WriteLine("\"Good Morning\"\n");
            //\'
            Console.WriteLine(@"***Use of (\') to print ('')***"+"\n");
            Console.WriteLine("\'Welcome to bootcamp\'");
            // \\
            Console.WriteLine(@"***Print \\ ***\n");
            Console.WriteLine("\\\\Good Morning\\Welcome to bootcamp");
            //Verbatim Strings
            Console.WriteLine(@"***Print Verbatim  Strings double quotaion followed by @ ***\n");
            Console.WriteLine(@"\\Hello\Student-Name");
        }
        /// <summary>
        /// String Builder
        /// </summary>
        public static void Str_Builder_Method()
        {
            Console.WriteLine("\n\n3. Explore and show the working of the various methods and properties in String Builder.");
            Console.WriteLine("***String Builder***");
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb.ToString());
            //Append
            Console.WriteLine("\n***Append String***");
            sb.Append("Good Morning");
            Console.WriteLine(sb.ToString());
            //AppendLine
            Console.WriteLine("\n***AppendLine appends the string at the end of the current String Builder object***");
            sb.AppendLine("How Are you");
            Console.WriteLine(sb.ToString());
            //Insert
            Console.WriteLine("\n***Insert String***");
            sb.Insert(17,"Have a nice day");
            Console.WriteLine(sb.ToString());
            //Remove
            Console.WriteLine("\n***Remove String***");
            sb.Remove(32,11);
            Console.WriteLine(sb.ToString());
            //Insert
            Console.WriteLine("\n***Insert String***");
            sb.Insert(5, "Very very");
            Console.WriteLine(sb.ToString());
        }
    }
}
