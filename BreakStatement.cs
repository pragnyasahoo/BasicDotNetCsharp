using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class BreakStatement
    {
        static void Main(string[] args)
        {
            //Break for for
            Console.WriteLine("Break for for ************");
            for (int i = 1; i <= 4; ++i)
            {

                // terminates the loop
                if (i == 3)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("Break with nested for ************");
            int sum = 0;
            for (int i = 1; i <= 3; i++)
            { //outer loop

                // inner loop
                for (int j = 1; j <= 3; j++)
                {
                    if (i == 2)
                    {
                        break;
                    }

                    Console.WriteLine("i = " + i + " j = " + j);

                }
            }

            Console.WriteLine("Break with foreach for ************");
            string s = "pragnya";

            // use of foreach loop
            foreach (char letter in s)
            {

                // terminates the loop
                if (letter == 'a')
                {
                    break;
                }

                Console.WriteLine(letter);
            }

            Console.ReadLine();

        }
    }

}
 
