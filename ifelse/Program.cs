using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the value :");
            n=Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.Write("even");
            }
            else 
            {
                Console.Write("Odd");
            }
         Console.ReadKey();
        }
    }
}
