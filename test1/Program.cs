using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your Age :");
            int age;
            age=Convert.ToInt32(Console.ReadLine());


            if (age == 0)
            {
                Console.WriteLine("no tickets");
            }
            else if ((age>5) && (age <= 10))
            {
                Console.WriteLine("free tickets");
            }
            else if ((age > 10) && (age <= 16))
            {
                Console.WriteLine("half tickets");
            }
            else if ((age > 16) && (age <= 50))
            {
                Console.WriteLine("full tickets");
            }
            else
            {
                Console.WriteLine("no trickets");
            }

            Console.WriteLine("program completed");
            Console.ReadLine();
        }
    }
}
