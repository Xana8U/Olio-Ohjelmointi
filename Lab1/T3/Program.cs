using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä luku 1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä luku 2 : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Syötä luku 3 : ");
            int n3 = int.Parse(Console.ReadLine());

            int sum = n1 + n2 + n3;
            Console.WriteLine("Lukujen summa on {0}", sum);
            Console.WriteLine("Lukujen keskiarvo on {0}", sum / 3);
            Console.ReadKey();
        }
    }
}
