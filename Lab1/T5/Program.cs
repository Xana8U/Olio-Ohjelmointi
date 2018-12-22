using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5 {
    class Program {
        static void Main() {
            Console.Write("Give seconds : ");
            int seconds = int.Parse(Console.ReadLine());
            int secremind = seconds % 60;
            int minutes = seconds / 60;
            int minremind = seconds % 60;
            int hours = seconds / 60 / 60;
            if (seconds < 60) {
                Console.WriteLine("Seconds can be shown as 0 hour(s) 0 minute(s) and {0} second(s)", seconds);
                Console.ReadKey();
            }
            else if (seconds >= 60 && minutes < 60){
                Console.WriteLine("Seconds can be shown as 0 hour(s) {0} minute(s) and {1} second(s)", minutes, secremind);
                Console.ReadKey();
            }
            else {
                Console.WriteLine("Seconds can be shown as {0} hour(s) {1} minute(s) and {2} second(s)", hours, minremind, secremind);
                Console.ReadKey();
            }
            
        }
    }
}
