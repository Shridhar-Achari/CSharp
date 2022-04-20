using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuging
{
    public class LoginExample
    {
        public static void Main()
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
            Console.Write("---------------------------------------\n");

            do
            {
                Console.Write("Input a username:");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "abcd" || password != "1234") && (ctr != 3));//semicolon missing and put “{“
            {



                if (ctr == 3)
                    Console.Write("\nLogin attemp three or more times. Try later!\n\n");
                else
                    Console.Write("\nThe password entered successfully!\n\n");
            }
        }
    }

}
