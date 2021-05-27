using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            Q5.AnArray();

        }
    }

    class Q5
    {
        public static void AnArray()
        {
            //ArrayList arr = new ArrayList(){ 10, false, new DateTime(2019, 01, 01), "sample string" };
            object[] a = new object[] { 10, false, new DateTime(2019, 01, 01), "sample string" };

            Console.WriteLine("Array Contents: ");
            foreach (var item in a)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
