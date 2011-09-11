using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_04_assignmentloops
{
	class Program
	{
		static void Main(string[] args)
		{
			int lower, upper;
			System.Console.Write("Enter lower bound: ");
			lower = int.Parse(System.Console.ReadLine());
			System.Console.Write("Enter upper bound: ");
			upper = int.Parse(System.Console.ReadLine());

			System.Console.Write("\nCalculating...");
			for (int i = 0; i <= upper - lower; i++) {
				int total = 1;	// 0! is 1
				System.Console.Write("\n{0}! = ", lower + i);
				for (int j = lower + i; j > 1; j--) {
					System.Console.Write("{0} * ", j);
					total *= j;
				}
				System.Console.Write("1 = {0}", total);
			}
		}
	}
}
