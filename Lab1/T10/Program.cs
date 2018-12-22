using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10 {
    class Program {
        static void Main() {
            int[] numerot = {
                1, 2, 33, 44, 55, 68, 77, 96, 100
            };
            for (int i = 0; i < numerot.Count(); i++) {
                if (numerot[i] % 2 == 0) {
                    Console.WriteLine("HEP");
                }
            }
            Console.ReadKey();
        }
    }
}
