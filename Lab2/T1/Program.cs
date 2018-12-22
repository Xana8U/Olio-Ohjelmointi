using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1 {
    class Program {
        static void Main() {
            /* Console.Write("Give a number : ");
            int numero = int.Parse(Console.ReadLine());
            string star = "*";
            for (int i = 0; i < numero; i++) {
                Console.WriteLine(star);
                star += "*";
            }
            Console.ReadKey();
            */

            Console.Write("Give a number : ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++) {
                for (int a = 0; a < i+1; a++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
