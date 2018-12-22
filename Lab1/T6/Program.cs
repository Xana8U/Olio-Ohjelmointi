using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6 {
    class Program {
        static void Main() {
            Console.Write("Give distance : ");
            double distance = double.Parse(Console.ReadLine());
            double consumption = distance / 100 * 7.02;
            double cost = consumption * 1.595;
            Console.WriteLine("Gasoline comsumption is {0:0.00} liters and the cost is {1:0.00} euros", consumption, cost);
            Console.ReadKey();
        }
    }
}
