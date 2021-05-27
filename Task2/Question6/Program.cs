using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(10, 20);
            var v = p.Deconstruct();
            Console.WriteLine("Tuple[item1] = {0} \nTuple[item2] = {1} ", v.Item1, v.Item2);
            Console.ReadLine();
        }
    }

    class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
        }

        public Tuple<int,int> Deconstruct()
        {
            return new Tuple<int, int>(X, Y);
        }
    }
}
