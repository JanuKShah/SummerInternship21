using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            s.Replace('o', 'i');
            s.Replace("r", string.Empty);
            Console.WriteLine(s);
            Console.ReadLine();

            /*
             Output: hello world
             Replace returns a new string after replacing 
            all occurences of a given string with the
            specified string.
            But the original string is not modified.
            To modify it, we have to reassign it the replaced string
            i.e. s = s.Replace('o','i');
             */
        }
    }
}
