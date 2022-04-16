using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tasks
{
    internal class Task_21
    {
        public static void Main(string[] args)
        {
            
            
            ///<summary>
            ///1. Write a program to get ( from the user) and display trainee details
            ///</summary>
            int t_id;
            String t_name, t_grp;
            Console.WriteLine("1. Write a program to get ( from the user) and display trainee details");
            Console.WriteLine("Enter Trainee Details:");
            Console.WriteLine("Enter Trainee ID:");
            t_id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name:");
            t_name = Console.ReadLine();
            Console.WriteLine("Enter Trainee Group:");
            t_grp= Console.ReadLine();
            Console.WriteLine($"\n*** Trainee Details ***");
            Console.WriteLine($"Trainee ID:{t_id}\nTrainee Name:{t_name}\nTrainee Group:{t_grp}");
            Console.WriteLine("______________________");

            ///<summary>
            ///2. Write a program to calculate the total and average of 3 subjects using if else concept
            ///</summary>
            int s_id, m1, m2, m3, avg, tot;
            String name;
            Console.WriteLine("2. Write a program to calculate the total and average of 3 subjects using if else concept");
            Console.WriteLine("Enter Student Mark Details:");
            Console.WriteLine("Enter Student Id:");
            s_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter The Marks in sub1:");
            m1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks in sub2:");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Marks in sub3:");
            m3 = Convert.ToInt32(Console.ReadLine());
             tot = m1 + m2 + m3;
             avg = tot / 3;
            if (m1 > 100 || m1 < 0 && m2 > 100 || m2 < 0 && m3 > 100 || m3 < 0)
            {
                Console.WriteLine("Invalid marks entered");
            }
            else
            {
                Console.WriteLine("\n***Student Mark Details***\n");
                Console.WriteLine($"Student ID:{s_id}\nStudent Name:{name}\nMark in Sub1:{m1}\nMark in sub2:{m2}\nMark in sub3:{m3}\nTotal Mark is:{tot}\nAverege mark is:{avg}");
            }
            Console.WriteLine("_______________________");


            calculator();
            NaturalNum();
            ///Automatically the default constructor is invoked
            Employee e = new Employee();
            ///Invoking the instance method
            e.display();
            //Automatically invokes the constructor with (int,string,int) format
            Employee e1 = new Employee(123,"Abhi",35000);
            //Automatically invokes the constructor with (string,int) format
            Employee e2=new Employee("HR",1001);
            
             //instance method is called/invoked
             Task_21 task = new Task_21();
             task.Instance_great();
             
            ///<summary>
            ///7. Explore - Ternary Operators, break and continue statements
            ///</summary>
            



        }


            ///<summary>
            ///3.Write a program to implement the working of a calculator using switch-case
            ///</summary>    
            public static void calculator()
            {   
                int ch, n1, n2, res;
                Console.WriteLine("3.Write a program to implement the working of a calculator using switch-case");
                Console.WriteLine("\n**** Calculator ***\n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());  
                switch(ch)
                {
                    case 1:Console.WriteLine("Enter 1st number:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res=n1+n2;
                    Console.WriteLine("Sum is:{0}",res);
                    break;
                    case 2:Console.WriteLine("Enter 1st number:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res=n1-n2;
                    Console.WriteLine("Difference is:{0}",res);
                    break;
                    case 3:Console.WriteLine("Enter 1st number:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res=n1*n2;
                    Console.WriteLine("Product is:{0}",res);
                    break;
                    case 4:Console.WriteLine("Enter 1st number:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    res=n1/n2;
                    Console.WriteLine("Quotient is:{0}",res);
                    break;
                    default:Console.WriteLine("Invalid Choice");
                    break;
                }
                Console.WriteLine("______________________");
            }
            ///<summary>
            ///4.Write a program to calculate the sum of natural numbers using while loop
            ///</summary>
            public static void NaturalNum()
            {
                int num;
                int sum=0;
                int i=1;
                Console.WriteLine("4.Write a program to calculate the sum of natural numbers using while loop");
                Console.WriteLine("\n**** Sum of Natual Numbers ****\n");
                Console.WriteLine("Enter the number:");
                num = Convert.ToInt32(Console.ReadLine());
                while (i <=num)
                {
                    sum+=i;
                    i++;
                }
                Console.WriteLine($"Sum of\t{num}"+"natural numbers is:{0}",sum);
                Console.WriteLine("______________________");
            }
            ///<summary>
            ///6. Write a program to show the difference between instance and static method
            ///</summary>
            public void Instance_great()
            {
                Console.WriteLine("Hello:");
                Console.Read();
            }   
        
        ///<summary>
        ///5.Write a program based on any concept to show the working of constructor overloading
        ///</summary>
        public class Employee
        {
            public int Emp_id;
            public String Ename;
            public Employee()
            {   
                Console.WriteLine("5.Write a program based on any concept to show the working of constructor overloading");
                Console.WriteLine("\n***Employee Details:***(Constructor)\n");
                Console.WriteLine("Enter Employee ID:");
                Emp_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                Ename = Console.ReadLine();
            }
            public void display()
            {
                Console.WriteLine("Employee Id is:{0}",Emp_id);
                Console.WriteLine("Employee Name is:{0}",Ename);
                Console.WriteLine("________________________");
            }
            public Employee(int eid, string e_name, int sal)
            {
                Console.WriteLine("\n***Employee Details***(Parameterised Constructor)\n");
                Console.WriteLine($"Employee Id is:{eid}");
                Console.WriteLine($"Employee Name is:{e_name}");
                Console.WriteLine($"Employee Salary is:{sal}");
                Console.WriteLine("________________________");
            }
            public Employee(string dept, int d_id)
            {
                Console.WriteLine("\n***Employee Details***(Parameterised Constructor)\n");
                Console.WriteLine($"Employee Name is:{dept}");
                Console.WriteLine($"Employee Salary is:{d_id}");
                Console.WriteLine("________________________");
            }
        }
     }      
}
