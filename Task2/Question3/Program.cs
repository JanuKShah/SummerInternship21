using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                arr[5] = 0;
                Console.WriteLine("arr[5] = {0}", arr[5]);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Overflow Exception Occured!!");
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index Out of Range Exception Occured!!");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
