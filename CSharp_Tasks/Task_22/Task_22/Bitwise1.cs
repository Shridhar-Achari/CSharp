using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    internal class Bitwise1
    {
        public static void Main()
        {

            int n1 = 13;
            int n2 = 15;
            int n3;
            Console.WriteLine("6. Write a program to show the working of Bitwise Operators.");
            ///Bitwise OR
            n3 = n1 | n2;
            Console.WriteLine("\nBitwise OR {0}OR{1}:",n1, n2);
            Console.WriteLine("Answer:"+n3);
            //Bitwise AND
            n3 = n1 & n2;
            Console.WriteLine("\nBitwise AND {0}AND{1}:", n1, n2);
            Console.WriteLine("Answer:"+n3);
            //Bitwise XOR
            n3 = n1 ^ n2;
            Console.WriteLine("\nBitwise XOR {0}XOR{1}:", n1, n2);
            Console.WriteLine("Answer:"+n3);
            //Bitwise complement
            int n4 = 48; 
            Console.WriteLine("\nComplement of{0}",n4);
            Console.WriteLine("Answer:"+~n4); 

            //Bitwise Left Shift Operator
            int n5 = 48;
            Console.WriteLine("\nLeft Shift Operator(<<):");
            Console.WriteLine("Left Shift1:\t{0}", n5 << 1);
            Console.WriteLine("Left Shift2:\t{0}", n5 << 2);
            Console.WriteLine("Left Shift3:\t{0}", n5 << 3);
            Console.WriteLine("Left Shift4:\t{0}", n5 << 4);

            int n6 = 64;
            //Bitwise Right Shift Operator
            Console.WriteLine("\nRight Shift Operator(>>):");
            Console.WriteLine("Right Shift1:\t{0}",n6 >> 1);
            Console.WriteLine("Right Shift2:\t{0}", n6 >> 2);
            Console.WriteLine("Right Shift3:\t{0}", n6 >> 3);
            Console.WriteLine("Right Shift4:\t{0}", n6 >> 4);
            Console.ReadLine();
        }
    }
}
