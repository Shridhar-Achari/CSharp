using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task_23
{
    public class Structures
    {
        public static void Main()
        {
            Student std = new Student();
            Student std1 = new Student(102, "Bharath", "MCA", 98);
            std.GetStd_Details();
            std.DisplayStd_Details();
        }
    }
    struct Student
        {
        public int Id;
        public string Name;
        public string Branch;
        public int Mark;
        public void GetStd_Details()
        {
            Console.WriteLine("***Student Details (Structure)***\n");
            Console.WriteLine("Please Enter Student Details:\n");
            Console.Write("Enter Student_Id:\t");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name:\t");
            Name = Console.ReadLine();
            Console.Write("Enter Student Branch:\t");
            Branch = Console.ReadLine();
            Console.Write("Enter Student Mark:\t");
            Mark = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStd_Details()
        {
            Console.WriteLine("****STUDENT DETAILS****\n");
            Console.Write("Student ID is:\t\t" + Id + "\nStudent Name is:\t" + Name + "\nStudent Branch is:\t" + Branch + "\nStudent Mark is:\t" + Mark + "\n");
        }
        //constructor
        internal Student (int std_id, String std_name, String std_barnch, int std_mark)
        {
            Id= std_id;
            Name= std_name;
            Branch= std_barnch;
            Mark= std_mark;
            Console.WriteLine("1. Write a program to show the working of parameterized constructors using Structures.");
            Console.WriteLine("***Student Details (Constructor)***\n");
            Console.WriteLine("Student ID is:\t\t" + Id + "\nStudent Name is:\t" + Name + "\nStudent Branch is:\t" + Branch + "\nStudent Mark is:\t" + Mark + "\n");
        }
    }   
}
