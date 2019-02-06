using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// hirsipuu

namespace T9 {
    class Program {
        static void Main(string[] args) {
            int lifes = 11;  // elämät
            List<int> indexes = new List<int>();  // sijainti tallennus arvatuille kirjaimille

            Console.WriteLine("Hirsipuu peli");
            Console.Write("Anna sana arvaajille: ");
            string sana = Console.ReadLine();
            char[] sanajono = sana.ToArray();  // iteroitava sanajono kirjaimille
            bool arvattu = false;
            string arvaus;
            List<string> arvatut = new List<string>();
            List<char> kirjaimet = new List<char>();
            List<char> vihjestructure = new List<char>();

            for (int i = 0; i < sana.Length; i++) {
                vihjestructure.Add('*');
            }


            while (arvattu == false) {
                Console.WriteLine("{0} Arvausta jäljellä\n", lifes);
                Console.Write("Väärät arvaukset: ");
                vaaralista();
                Console.Write("väärät kirjaimet: ");
                vaarakirjain();

                Console.Write("Sanavinkki:  ");
                sanavinkki();

                if (lifes == 0) {
                    Console.WriteLine("Elämät loppuivat, hävisit pelin");
                    break;
                }

                Console.Write("Arvaa sana tai kirjain: ");
                arvaus = Console.ReadLine();

                // Arvaus koko sanalle
                if (arvaus.Length < 1) {
                    if (arvaus != sana) {
                        Console.WriteLine("\nVäärä arvaus! Arvaa uudelleen.");
                        arvatut.Add(arvaus);
                        lifes -= 1;
                        break;
                    }
                    else if (arvaus == sana) {
                        Console.WriteLine("OIKEIN, Voitit pelin!!!");
                        arvattu = true;
                    }
                    else {
                        continue;
                    }
                }
                // carvaus char kirjainveikkauksiin
                else if (arvaus.Length == 1) {
                    int status = 0;  // löytyikö kirjainta vai ei
                    int[] inindex = new int[sana.Length];  // samojen kirjainten takia usemapi index mahdollisuus
                    int pos = 0;
                    char carvaus = arvaus[0];
                    for (int i = 0; i < sanajono.Length; i++) {
                        if (sanajono[i] == carvaus) {
                            inindex[pos] = i;
                            status = 1;
                            Console.WriteLine("Kirjain löytyi sanasta");
                            pos += 1;
                        }
                        
                    }
                    if (status == 0) {
                        kirjaimet.Add(carvaus);
                        Console.WriteLine("Kirjainta ei löytynyt");
                    }
                    else if (status == 1) {
                        for (int i = 0; i < inindex.Length; i++)
                            indexes.Add(inindex[i]);
                            status = 0;
                    }
                }
                else {
                    continue;
                }
            }

            // arvatuille kirjaimille
            void sanavinkki() {

                for (int i = 0; i < sana.Length; i++) {
                    for (int b = 0; b < indexes.Count(); b++) {
                        if (indexes[b] == i) {
                            vihjestructure[i] = sana[i];
                            break;
                        }
                        else {
                            continue;
                        } 
                    }
                    Console.Write(vihjestructure[i]);
                }
                Console.Write("\n\n");
            }

            // arvatut sanat lista
            void vaaralista() {
                for (int i = 0; i < arvatut.Count(); i++) {
                    Console.Write("{0}, ", arvatut[i]);
                }
                Console.Write("\n\n");
            }
            // arvatut sanat lista
            void vaarakirjain() {
                for (int i = 0; i < kirjaimet.Count(); i++) {
                    Console.Write("{0}, ", kirjaimet[i]);
                }
                Console.Write("\n\n");
            }
        }
    }
}
