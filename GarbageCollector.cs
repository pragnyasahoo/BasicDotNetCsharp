using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{

    //Garbage collector with generation of the object
    class Calci 
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Multi(int a, int b)
        {
            return (a * b);
        }
        public int Divide(int a, int b)
        {
            return (a / b);
        }
    }
    internal class GarbageCollector
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("GC Maximum Generations:" + GC.MaxGeneration);
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
            Calci oCalci = new Calci();
            Console.WriteLine("Calci object is now on " + GC.GetGeneration(oCalci) + " Generation");
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
            Console.WriteLine("Garbage Collection Occured in 0th Generation:" + GC.CollectionCount(0));
            Console.WriteLine("Garbage Collection Occured in 1th Generation:" + GC.CollectionCount(1));
            Console.WriteLine("Garbage Collection Occured in 2th Generation:" + GC.CollectionCount(2));
            GC.Collect(0);
            Console.WriteLine("Garbage Collection Occured in 0th Generation:" + GC.CollectionCount(0));

        }
    }
}
