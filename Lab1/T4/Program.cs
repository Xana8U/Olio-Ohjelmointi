using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Syötä ikäsi : ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18) {
                Console.WriteLine("Alaikäinen");
                Console.ReadKey();
            }
            else if (age >= 18 && age <= 65) {
                Console.WriteLine("Aikuinen");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("Seniori");
                Console.ReadKey();
            }
           
        }
    }
}
