using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuging
{
    public class Arrays
    {
        public static void Main()////Main() M should be capital
        {
            int i, j;
            int[,]arr1 = new int[3,3];////2D Array so we have to put comma

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("-----------------------------------------\n");


            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");//Missing semicolon
            for (i = 0; i < 3; i++)//i<2
            {
                for (j = 0; j < 3; j++)//j<3
                {
                    Console.Write("element - [{0},{1}] : ", i, j);//Have to use 2 input so use another string formatter {1} within [] and console C should be capital


                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i=0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}

