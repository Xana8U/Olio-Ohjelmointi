using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8 {
    class Program {
        static void Main() {
            Console.Write("Give a number : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Give a number : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Give a number : ");
            int n3 = int.Parse(Console.ReadLine());

            List<int> lista = new List<int> { n1, n2, n3 };
            Console.WriteLine("The biggest number is {0}", lista.Max());
            Console.ReadKey();
        }
    }
}

