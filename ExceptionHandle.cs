using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class ExceptionHandle
    {
        int result;

        public ExceptionHandle()
        {
            result = 0;
        }
        public int division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                return 0;
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
            return result;
        }
    }

        class ExceptionHandles
        {
            static void Main(string[] args)
            {
                ExceptionHandle d = new ExceptionHandle();
                d.division(25, 0);
                Console.ReadKey();
            }

        }
    }
 
