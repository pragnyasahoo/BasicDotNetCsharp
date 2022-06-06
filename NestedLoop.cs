using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
	internal class NestedLoop
	{
		public static void Main(string[] args)
		{

			/* Print 
			1
			2 2
			3 3 3
			4 4 4 4
			5 5 5 5 5*/

			int i = 1;
			while (i <= 5)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(i + " ");
				}

				Console.WriteLine();
				i++;
			}

			/* Print 
		   1
		   1 2
		   1 2 3
		   1 2 3 4
		   1 2 3 4 5*/
			Console.WriteLine("using For Loop *****************");


			for (int i2 = 1; i2 <= 5; i2++)
			{
				for (int j2 = 1; j2 <= i2; j2++)
				{
					Console.Write(j2 + " ");
				}
				Console.WriteLine();
			}

			/*(0,0) (0,1)
			(1,0) (1,1)*/

			Console.WriteLine("using   while Loop *****************");

			int i3 = 0;
			while (i3 < 2)
			{
				int j3 = 0;
				while (j3 < 2)
				{
					Console.Write("({0},{1}) ", i3, j3);
					j3++;
				}
				i3++;
				Console.WriteLine();
			}

			/*(0,0) (0,1)
			(1,0) (1,1)*/

			Console.WriteLine("using do while Loop   *****************");

			int i1 = 0;
			do
			{
				int j1 = 0;
				do
				{
					Console.Write("({0},{1}) ", i1, j1);
					j1++;
				} while (j1 < 2);
				i1++;
				Console.WriteLine();

			} while (i1 < 2);


			/* Print the postion with character
			 * Character in 1 position is P
			Character in 2 position is r
			Character in 3 position is a
			Character in 4 position is g
			Character in 5 position is n
			Character in 6 position is y
			Character in 7 position is a*/
			Console.WriteLine("using of foreach loop *****************");
			// use of foreach loop
			string s = "Pragnya";
			int counter = 0;
			foreach (char letter in s)
			{
				counter++;
				Console.WriteLine("Character in {0} position is {1} ", counter, letter);
			}

			/* Print the loop
			  Outer Loop runs 5 times
			 Inner Loop runs 25 times*/
			Console.WriteLine("*** Calculate the no of loop*****************");
			int outerLoop = 0, innerLoop = 0;
			for (int i5 = 1; i5 <= 5; i5++)
			{
				outerLoop++;
				for (int j5 = 1; j5 <= 5; j5++)
				{
					innerLoop++;
				}
			}
			Console.WriteLine("Outer Loop runs {0} times", outerLoop);
			Console.WriteLine("Inner Loop runs {0} times", innerLoop);

		}

	}
}
