using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3 {
    class Program {
        static void Main() {
            int[] pisteet = new int[5];
            for (int i = 0; i < 5; i++) {
                Console.Write("Give points : ");
                int n1 = int.Parse(Console.ReadLine());
                pisteet[i] = n1;
            }
            int calc = pisteet.Sum() - pisteet.Max() - pisteet.Min();
            Console.WriteLine("Total points are {0}", calc);
            Console.ReadKey();
        }
    }
}
