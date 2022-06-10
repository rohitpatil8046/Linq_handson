using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class Linq_practice
    {
        static void Main(string[] args)
        {

            string[] names = { "Rohit","Amit","Swapnil","Karan","Saurav" };
            var a = from name in names where name.Contains("a") select name;

            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
