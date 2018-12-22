using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7 {
    class Program {
        static void Main() {
            Console.Write("Give a year : ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0) {
                if (year % 400 == 0) {
                    Console.WriteLine("Year is a leap year.");
                    Console.ReadKey();    
                }
                else {
                    Console.WriteLine("Year is not a leap year");
                    Console.ReadKey();
                }
            }
            else {
                Console.WriteLine("Year is not a leap year");
                Console.ReadKey();
            }

        }
    }
}
