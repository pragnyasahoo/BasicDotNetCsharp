using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class SwitchCase
    {
        static void Main(string[] args)
        {

            int input = 2; //change value of this input to see output for different cases 

            // switch with integer type
            switch (input)
            {
                case 1:
                    Console.WriteLine("Your input for case 1 is: {0}", input);
                    break;
                case 2:
                    Console.WriteLine("Your input for case 2 is: {0}", input);
                    break;
                default:
                    Console.WriteLine("Your input in default case is: {0}", input);
                    break;
            }

            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;

                case 'e':
                    Console.WriteLine("Vowel");
                    break;

                case 'i':
                    Console.WriteLine("Vowel");
                    break;

                case 'o':
                    Console.WriteLine("Vowel");
                    break;

                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Not a vowel");
                    break;

            }

        }
    }
}
