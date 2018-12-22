using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program // Luokka johon ohjelma kuuluu 
    {
        static void Main() {  // Ohjelman pääfunktio
            Dictionary<int, string> kirjasto = new Dictionary<int, string>(){  // Luo uuden kirjaston integer avaimella ja string arvolla
                    {1, "one"},  // predefined instances
                    {2, "two"},
                    {3, "three"}
            };
            Console.WriteLine("Give a number > ");  // TUlostaa merkkijonon
            int number = int.Parse(Console.ReadLine());  // Tekee muuttujan number, odottaa että käyttäjä syöttää merkkijonon.
            if (number > 3 || number < 1){
                Console.WriteLine("Joku muu luku");
                Console.ReadKey();
            }
            else{
            Console.WriteLine("number is {0}", kirjasto.Values.ElementAt(number - 1));  // Lukee teksti arvon kirjastosta käyttäen käyttäjän syöttämää numeroa avaimena
            Console.ReadKey();
            }
        }
    }
}
