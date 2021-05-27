using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int sum = Calculator.AddNums(a, b);
            string output = String.Format("The sum of {0} and {1} is {2}", a, b, sum);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }

    class Calculator
    {
        public static int AddNums(int a , int b)
        {
            return a + b;
        }
    }
}
