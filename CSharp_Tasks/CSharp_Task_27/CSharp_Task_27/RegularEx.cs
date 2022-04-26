using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharp_Task_27
{
    internal class ValidateNameException : Exception
    {
        public ValidateNameException(string message) : base(String.Format("\nINVALID NAME FORMAT:{0}", message))
        {

        }
    }
    internal class ValidateNumberException : Exception
    {
        public ValidateNumberException(string message) : base(String.Format("\nINVALID NUMBER FORMAT:{0}", message))
        {

        }
    }
    public class Student
    {
        public string name { get; set; }
        public string mobile { get; set; }
    }

    public class RegularEx
    {
        public static void Main()
        {
            Student student = null;
            try
            {
                student = new Student();
                Console.WriteLine("1. Show the working of Custom Exception and Regular Expression(mobile and name)\n");
                Console.Write("Enter the Student Name(First Letter Should be Capital letter):\t");
                student.name = Console.ReadLine();
                ValidateName(student.name);
                Console.Write("\nEnter the Student Mobile Number(Only 10d igits):\t");
                student.mobile = Console.ReadLine();
                ValidateMobile(student.mobile);
                Console.WriteLine("VALID NAME:{0}", student.name);
                Console.WriteLine("VALID MOBILE NUMBER:{0}", student.mobile);
            }
            catch (ValidateNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ValidateNumberException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ValidateName(string std)
        {
            Regex regex = new Regex("^[A-Z][a-z]+$");
            if(!regex.IsMatch(std))
            throw new ValidateNameException(std);
        }
        public static void ValidateMobile(string stdm)
        {
            string mregexp = @"(^[0-9]{10}$)";
            Regex r = new Regex(mregexp);
            if (!r.IsMatch(stdm))
                throw new ValidateNumberException(stdm);
        }
    }
}

