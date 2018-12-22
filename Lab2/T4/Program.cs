using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4 {
    class Program {
        static void Main() {
            Dictionary<int, string> grades = new Dictionary<int, string>() {
                {0, ""},
                {1, ""},
                {2, ""},
                {3, ""},
                {4, ""},
                {5, ""}
            };
            Console.Write("Please insert the number of grades to be input : ");
            int totalnum = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalnum; i++) {
                Console.Write("Please enter a grade {0}: ", i+1);
                int grade = int.Parse(Console.ReadLine());
                grades[grade] += "*";
            }
            Console.Write("Grades: \n" +
                          "{0}: {1}\n" +
                          "{2}: {3} \n" +
                          "{4}: {5} \n" +
                          "{6}: {7} \n" +
                          "{8}: {9} \n" +
                          "{10}: {11} \n", grades.Keys.ElementAt(0), grades.Values.ElementAt(0), grades.Keys.ElementAt(1), grades.Values.ElementAt(1), grades.Keys.ElementAt(2), grades.Values.ElementAt(2),
                                           grades.Keys.ElementAt(3), grades.Values.ElementAt(3), grades.Keys.ElementAt(4), grades.Values.ElementAt(4), grades.Keys.ElementAt(5), grades.Values.ElementAt(5));
            Console.ReadKey();

        }
    }
}
