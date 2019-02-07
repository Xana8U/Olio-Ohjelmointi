using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois, 
// sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).
namespace T1 {
    class Program {
        static void Main(string[] args) {
            int status = 0;
            int lampotila = 0;
            int kosteusp = 30;
            List<int> numerot = new List<int>();

            Console.WriteLine("Anna kiukaan asetukset");
            Console.WriteLine("Muodossa: 1 tai 0(päällä / pois), 0-1000(lämpötila), 0-100(kosteus), esim: 1,80,40");
            string arvot = Console.ReadLine();

            numerot = arvot.Split(',').Select(int.Parse).ToList();

            status = numerot[0];
            lampotila = numerot[1];
            kosteusp = numerot[2];

            Kiuas taso1 = new Kiuas(status, lampotila, kosteusp);
            Console.WriteLine(taso1.toPrint());

        }
    }
    public class Kiuas{
        int status = 0;  // pois päältä
        int lampotila = 0;
        int kosteusp = 30;

        public Kiuas(int status, int lampotila, int kosteusp) {
            this.status = status;
            this.lampotila = lampotila;
            this.kosteusp = kosteusp;
        }

        public int getStatus() {
            return status;
        }
        public int getLampo() {
            return lampotila;
        }
        public int getKosteus() {
            return kosteusp;
        }
        public string toPrint() {
            if (this.status == 1) {
                return ("Sauna on päällä\n"
                        + "Saunan Lämpötila on " + this.lampotila.ToString() + " astetta\n"
                        + "Saunan Kosteusprosentti on " + this.kosteusp.ToString() + "%");
            }
            else if (this.status == 0) {
                return ("Sauna on pois päältä\n"
                        + "Saunan Lämpötila on " + this.lampotila.ToString() + " astetta\n"
                        + "Saunan Kosteusprosentti on " + this.kosteusp.ToString() + "%");
            }
            else {
                return ("Error!");
            }
        }
    }
}
