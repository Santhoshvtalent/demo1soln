using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace testpro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p = "";
         
                int emptype, age;
            while (p.ToLower() != "no")
            {
                Console.WriteLine("Employee Type ");
            Console.WriteLine("press 1 for permanant employee ");
            Console.WriteLine("press 2 for temprory  employee");
            Console.Write("select your option :");
            emptype = Convert.ToInt32(Console.ReadLine());
           

                if (emptype == 1 || emptype == 2) 
            {
                Console.WriteLine("Enter the Age");
                age = Convert.ToInt32(Console.ReadLine());
                if (emptype == 1)
                {

                    if ((age > 25) && (age < 41))
                    {
                        Console.WriteLine("salary =25000");
                    }
                    else if ((age >= 41) && (age < 59))
                    {
                        Console.WriteLine("salary =41000");
                    }
                    else
                    {
                        Console.WriteLine("no jobs");

                    }
                }
                else if (emptype == 2)
                {
                    if ((age >= 25) && (age < 41))
                    {
                        Console.WriteLine("salary =15000");
                    }
                    else if ((age >= 41) && (age > 59))
                    {
                        Console.WriteLine("salary =25000");
                    }
                    else
                    {
                        Console.WriteLine("no jobs");

                    }
                }
                else
                {
                    Console.WriteLine("invaild employee type");
                }
            }
            else { Console.WriteLine("Enterd invalid data please enter either 1 or 2 onlt nothing else "); }

            Console.WriteLine("do you want continue please enter yes or else no");
               p=Console.ReadLine();

                if (p.ToLower() == "no")
                {
                    Console.WriteLine(" program terminated successfully");
                }
                


            }
            Console.ReadKey();




        }

    }
}
