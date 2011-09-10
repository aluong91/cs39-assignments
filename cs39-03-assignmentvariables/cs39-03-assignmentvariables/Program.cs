using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs39_03_assignmentvariables
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] input =  new float[10];
            float sum = 0;

            for (int i = 0; i < input.Length; i++) {
                System.Console.Out.Write("Enter number {0}: ", i + 1);
                input[i] = float.Parse(System.Console.ReadLine());
                sum += input[i];
            }

            Array.Sort(input);
            System.Console.Out.Write("\nYou entered");
            for (int i = 0; i < input.Length; i++)
                System.Console.Out.Write(" {0}", input[i]);

            System.Console.Out.WriteLine("\nThe average is {0}", sum / input.Length);
            System.Console.Out.WriteLine("The median is {0}", input[4]);
            System.Console.Out.WriteLine("The sum is {0}", sum);
        }
    }
}
