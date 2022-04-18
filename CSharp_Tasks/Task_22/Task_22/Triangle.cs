using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22
{
    public class Triangle
    {
        ///<summary>
        ///1. Write a program to print Pascal Triangle(any pattern).
        ///2. Write a program to print Floyd Triangle.
        ///Pattern
        ///------------
        ///1
        ///2 3
        ///4 5 6 
        ///3. Explore and show the working of the various methods and properties in Strings.
        ///3. Explore and show the working of the various methods and properties in String Builder.

        ///4. Write a program to calculate the sum of naturals numbers using 1D Array(get the size of the array and input from the user).
        ///5. Write a program to perform matrix addition using 2D Arrays.
        ///6. Write a program to show the working of Bitwise Operators.
        ///7. Write a program to show the working of 1D Jagged array.
        ///</summary>
        public static void Main()
        {
            Console.WriteLine("***Triangle***\n");
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
