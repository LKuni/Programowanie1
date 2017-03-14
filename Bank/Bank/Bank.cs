using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        public string ImieINazwisko;
        public string NumerKonta;
        public double Fundusze;
        public int IDKonta;

        static int nr = 1;

        public void WplacPieniadze(double kwota)
        {
            if (kwota > 0)
            {
                Fundusze += kwota;
                Console.WriteLine("Kwota " + kwota + " zł została wpłacona na konto.");
            }
            else
            {
                Console.WriteLine("Nie możesz wpłacić ujemnej kwoty.");
            }
        }

        public void Wyplacpieniadze(double kwota)
        {
            if ((Fundusze - kwota) >= 0)
            {
                Fundusze -= kwota;
                Console.WriteLine("Wypłacono " + kwota);
            }
            else
            {
                Console.WriteLine("Nie masz tyle środków na koncie.");
            }
        }

        public void ZmienFunduszeKonta(double odsetki)
        {
            Fundusze *= (1 + odsetki / 100);
        }

        public void UsunKonto()
        {
            if (Fundusze != 0)
                Console.WriteLine("Konto nie jest puste");
            else
                Console.WriteLine("Usunieto");
        }

        public Bank(string ImieINazwisko, string NrKonta, double Fundusze)
        {
            this.ImieINazwisko = ImieINazwisko;
            this.NumerKonta = NrKonta;
            this.Fundusze = Fundusze;
            this.IDKonta = nr;
            nr++;
        }

        public void SprawdzFundusze()
        {
            Console.WriteLine("Twoje środki na koncie są równe " + Fundusze);
        }
        

    }
}

