using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program // Luokka johon ohjelma kuuluu 
    {
        static void Main()
        {
            Console.Write("Give point limit : ");
            int number = int.Parse(Console.ReadLine());
            if (number > 12 || number < 0) {
                Console.WriteLine("Invalid input. Use numbers within range 0-12");
                Console.ReadKey();
            }
            else if (number <= 11) {
                Console.WriteLine("School number is {0}", number / 2);
                Console.ReadKey();
            }
            else {
                Console.WriteLine("School number is 5");
                Console.ReadKey();
            }
            
        }
    }
}
