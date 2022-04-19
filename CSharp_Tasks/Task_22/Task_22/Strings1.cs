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
            string name = "Shridhar";
            string group = "MARS";
            Console.WriteLine("Name is:{0}", name);
            Console.WriteLine("Course is:{0}", group);
            //length
            Console.WriteLine("***Length of the String***");
            string str = "BootCamp";
            Console.WriteLine("String is"+str);
            int length = str.Length;
            Console.WriteLine("Length is:" + length);

            //Concatenation
            Console.WriteLine("***Concatenating of the 2 Strings***");
            string str1 = "DLithe";
            Console.WriteLine("String 1 is:"+str1);
            string str2 = "BootCamp";
            Console.WriteLine("String 2 is:" + str2);
            string add =string.Concat(str1, str2);
            Console.WriteLine("Joined String is:"+add);

            //character array
            char[] Training = { 'B','O','O','T',' ','C','A','M','P' };
            //Pass the character array to String Class
            String train = new String(Training);
            Console.WriteLine("Character from Training passed to String class:{0}", train);
            
            //Verbatim Strings
            Console.WriteLine(@"\\CSharp\Strings");

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
            //Insert
            sb.Insert(5, "Very very");
            Console.WriteLine(sb.ToString());
        }
    }
}
