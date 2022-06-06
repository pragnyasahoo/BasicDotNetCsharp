using ConsoleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class AddNos
    {
        public int a;
        public int b;
        public int total;

        public void display()
        {
            Console.WriteLine("Enter a integer value for a");
            a = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Please enter a integer value of b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value of b: " + b);
            total = a + b;
            Console.WriteLine("total: " + total);

            Boolean a1 = total >= 100 ? true : false;

            if (true) 
            { 
                Console.WriteLine("It is a 3 digit number  by terinary operator :");
            }
            else 
            { 
                Console.WriteLine("It is  not a 3 digit number  by terinary operator :"); 
            }


            if (total >= 100)
            {
                Console.WriteLine("It is a 3 digit number");
            }
            else
            {
                Console.WriteLine("It is not a 3 digit number");

            }
            Console.ReadKey();
        } 

    }
    internal class PrintSeriesno
    {
        static void Main(String[] args)
        {
            AddNos obj = new AddNos();
            obj.display();
            Console.ReadKey();

        }
    }
}

