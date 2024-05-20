using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ifCoditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("enter the value :");
            n=Convert.ToInt32(Console.ReadLine());
            if (n % 8 == 0)
            { 
                Console.WriteLine("value is divisble by 8 " );
            }
            Console.WriteLine("program complted ");
            Console.ReadKey();

        }
    }
}
