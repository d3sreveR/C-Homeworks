using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Class01
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "*";


            for (int i = 0; i<4; i++)
            {
                Console.WriteLine(a);
                a += a;
                //Console.WriteLine("");
            }

            Console.WriteLine("  *  ");
            Console.WriteLine("  *  ");
            Console.WriteLine(" *** ");
            Console.WriteLine("* * *");
            Console.WriteLine("  *  ");
            Console.WriteLine("  *  ");
            Console.WriteLine(" * * ");
            Console.WriteLine("*   *");
            Console.ReadKey();
            
        }
    }
}
