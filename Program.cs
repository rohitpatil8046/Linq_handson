using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] age = { 12, 33, 45, 34, 15, 34, 66, 78, 65, 89, 87, 56, 55, 90, 87 };
            var a = from i in age where i > 20 orderby i select i;

            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
