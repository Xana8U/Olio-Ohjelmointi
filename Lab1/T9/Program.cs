using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T9 {
    class Program {
        static void Main() {
            int number = 1;
            List<int> numbers = new List<int>();
            while (number != 0) {
                Console.Write("Anna numero : ");
                number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            Console.WriteLine("Lukujen summa on {0}", numbers.Sum());
            Console.ReadKey();

        }
    }
}
