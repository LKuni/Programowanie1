using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardowyCzlowiek
{
    class StandardowyCzlowiek
    {
        private string Imie;
        private int Wiek;
        public static int IloscKosci = 206;
        private string Pochodzenie;
        public static int IloscChromosomow = 46;

        public StandardowyCzlowiek(string Imie, int Wiek, string Pochodzenie)
        {
            this.Imie = Imie;
            this.Wiek = Wiek;
            this.Pochodzenie = Pochodzenie;
        }

        public int getWiek()
        {
            return this.Wiek;
        }

        public string getImie()
        {
            return this.Imie;
        }
        public string getMiejscePochodzenia()
        {
            return this.Pochodzenie;
        }

        public void uniwersalne()
        {
            Console.WriteLine("Ilosc kosci standardowego czlowieka to " + IloscKosci + ", a ilosc chomosomów to " + IloscChromosomow);
        }
    }
}
