using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mukorcsolya
{
    class Mukorcsolya
    {
        string nev;
        string orszagkod;
        double tpont;
        double kpont;
        byte hibapont;

        public string Nev
        {
            get;
            private set;
        }

        public string Orszagkod
        {
            get;
            private set;
        }

        public double Tpont
        {
            get;
            private set;
        }

        public double Kpont
        {
            get;
            private set;
        }

        public byte Hibapont
        {
            get;
            private set;
        }

        public Mukorcsolya(string egysor)
        {
            // Konstruktor készítés string típusú paraméterrel            
            // Készítünk egy "adatok" nevű string tömböt, amit feltöltünk, és ;-el elválasztjuk őket.
            // Ezt követően szétdaraboljuk őket a ; mentén.
            // FONTOS, HOGY A "."-T KICSERÉLJÜK ","-RE, mert ezt kéri a feladat!
            string[] adatok = egysor.Split(';');
            nev = adatok[0];
            orszagkod = adatok[1];
            tpont = double.Parse(adatok[2].Replace('.', ','));
            kpont = double.Parse(adatok[3].Replace('.', ','));
            hibapont = byte.Parse(adatok[4]);
        }
    }
}
