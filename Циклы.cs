using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы_while_и_do_while
{
    internal class Program
    {
        // В С# имеются 4 вида циклов (for, while, do...while и foreach)
        // Циклы позволяют выполнить блок кода повторно до тех пор, пока уловлетворятся определенные действия. 

        /*
        *
        *while
        *do while 
        *for
        *foreach
        */

        /* while (условие)
          {
            действия цикла;
          }


         //do
           {
             действия цикла;
           }
          while (условие)
                          */
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
