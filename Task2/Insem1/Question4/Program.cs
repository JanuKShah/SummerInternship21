using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            KnowVar k = new KnowVar();
            k._m = 10;
            k.MyMethod(k._m);
            k.MyMethod(k._m, 20);
            Console.ReadLine();
        }
    }

    class KnowVar
    {
        public int _m { get; set; }
        //var _m = 10;
        public void MyMethod(int i, int j = 10)
        {
            var k = i + j;
            var sum = "The sum";
            int n;
            string mul;
            n = i * j;
            mul = "The multiplication";
            var ob = new KnowVar();
            KnowVar ob2 = null;
            Console.WriteLine(sum +" " +k.ToString());
            Console.WriteLine(mul + " " + n.ToString());
        }
    }
}
