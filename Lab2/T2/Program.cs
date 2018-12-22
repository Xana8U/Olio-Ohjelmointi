using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2 {
    class Program {
        static void Main() {
            Console.Write("Give a number : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Give a number : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Give a number : ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Write("Give a number : ");
            int n4 = int.Parse(Console.ReadLine());
            Console.Write("Give a number : ");
            int n5 = int.Parse(Console.ReadLine());

            int[] luvut = {n1, n2, n3, n4, n5};
            /*
            int[] luvut = {n1, n2, n3, n4, n5};
            Console.Write("Numbers are ");
            foreach (int i in luvut) {
                Console.Write("{0},", luvut[luvut.Count()-i]);
            }
            */
            string[] luvut2 = new string[5];
            Console.Write("Numbers are ");
            for (int i = 0; i < luvut.Count(); i++) {
                luvut2[i] = luvut[luvut.Count() - 1 - i].ToString();
            }
            String format;
            format = String.Join(", ", luvut2);
            Console.Write(format);

            Console.ReadKey();
        }
    }
}
