using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы_while_и_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;

            do
            {
                Console.Write("a= ");
                Console.WriteLine(a);
                Console.Write("b= ");
                Console.WriteLine(b);
                
                a++;
                b++;
            }
            while (a < 12 && b < 11);

        }
    }
}
