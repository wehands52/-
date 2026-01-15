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

            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 10);

        }
    }
}
