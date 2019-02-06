using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8 {
    class Program {
        static void Main(string[] args) {
            // Tee ohjelma, joka kysyy käyttäjältä merkkijonon(lause).Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.
            Console.Write("Insert a string for palindrome test: ");
            string syote = Console.ReadLine();
            
            if (syote.Reverse().SequenceEqual(syote)) {
                Console.WriteLine("The string \"{0}\" is a palindrome!", syote);
            }
            else {
                Console.WriteLine("The string is not a palindrome");
            }
        }
    }
}
