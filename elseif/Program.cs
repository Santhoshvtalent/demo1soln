using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b ,c;
            
            Console.Write("enter a the value :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter b the value :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter c the value :");
            c = Convert.ToInt32(Console.ReadLine());


            if ((a > b) && (a > c))
            {
                Console.Write("a is bigger value:");
            }
            else if ((b > a) && (b > c))
            {
                Console.Write("b is bigger value:");
            }
            else
            {
                Console.Write("c is bigger value:");

            }
        Console.ReadKey();

        }
    }
}
