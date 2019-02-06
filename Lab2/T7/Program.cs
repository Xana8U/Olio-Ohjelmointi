using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. 
 * Tulosta lopuksi lajitellun taulukon sisältö.
 */

namespace T7 {
    class Program {
        static void Main(string[] args) {
            int[] array1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] array2 = new int[5] { 5, 15, 25, 35, 45 };
            int[] array3 = new int[array1.Length + array2.Length];

            array3 = array1.Concat(array2).ToArray();
            for (int i = 0; i < array1.Length; i++) {

            }
            Console.Write("Numbers in Array 1: ");
            for (int i = 0; i < array1.Length; i++) {
                Console.Write("{0},", array1[i]);
            }
            Console.Write("\nNumbers in array 2: ");
            for (int i = 0; i < array2.Length; i++) {
                Console.Write("{0},", array2[i]);
            }
            Array.Sort(array3);
            Console.Write("\nNumbers in the combined array: ");
            for (int i = 0; i < array3.Length; i++) {
                Console.Write("{0},", array3[i]);
            }
            Console.ReadKey();
        }
    }
}
