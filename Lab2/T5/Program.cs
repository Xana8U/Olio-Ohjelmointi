using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 7
        *
       ***
      *****
     *******
    *********
        *
        * 
 */


namespace T5 {
    class Program {
        static void Main() {
            Console.Write("Give a number : ");
            int korkeus = int.Parse(Console.ReadLine());
            int offset = (korkeus - 2) * 2 / 2;
            for (int i = 0; i < offset; i++) {
                string space = String.Concat(Enumerable.Repeat(" ", offset - i));
                string starL = String.Concat(Enumerable.Repeat("*", i + 1));
                string starR = String.Concat(Enumerable.Repeat("*", i));

                Console.Write(space);
                Console.Write(starL);
                Console.Write(starR);
               
                Console.WriteLine("");
            }
            string trunk = String.Concat(Enumerable.Repeat(" ", (korkeus - 2) * 2 / 2));
            Console.WriteLine("{0}*", trunk);
            Console.WriteLine("{0}*", trunk);

            Console.ReadKey();

        }
    }
}
