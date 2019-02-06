using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    /*
     * Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
     * Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. 
     * Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle.
     */ 
    
namespace T6 {
    class Program {
        static void Main() {
            int tries = 0;
            Random rand = new Random();
            int value = rand.Next(0, 101);

            int randomsgame(int args) {
                tries += args;
                
                Console.WriteLine("Guess #{0}", tries);
                Console.Write("Guess a number: ");
                int guess;
                try {
                    guess = int.Parse(Console.ReadLine());
                }
                catch {
                    randomsgame(1);
                }
                
                if (value < guess) {
                    Console.WriteLine("Wrong guess, guess lower...");
                    randomsgame(1);
                }
                else if (value > guess) {
                    Console.WriteLine("Wrong guess, guess higher...");
                    randomsgame(1);
                }

                else if (value == guess) {
                    Console.WriteLine("Congratulations!!! \nThe number indeed was {0}", value);
                    System.Environment.Exit(0);
                }
                return 0;
            }
            randomsgame(0);
        }
    }
}

