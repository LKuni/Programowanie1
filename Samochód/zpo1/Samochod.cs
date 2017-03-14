using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zpo1
{
    class Samochod
    {
        public string Marka;
        public int LiczbaKol;
        public double Predkosc;
        public string Kolor;
        public int Rocznik;

        public void Jedz(double Predkosc){
            if (Predkosc > 0){
                this.Predkosc = Predkosc;
                //Console.WriteLine("Pojazd jedzie z prędkością " + Predkosc);
            }
        }

        public void Hamuj()
        {
            Predkosc = 0;
            //Console.WriteLine("Pojazd hamuje");
        }

        public Samochod(int LiczbaKol, string Marka)
        {
            Predkosc = 0;
            this.LiczbaKol = LiczbaKol;
            this.Marka = Marka;
            Kolor = "Czarny";
            Rocznik = 2016;
        }

        public Samochod(int LiczbaKol, string Marka, string Kolor, int Rocznik)
        {
            Predkosc = 0;
            this.LiczbaKol = LiczbaKol;
            this.Marka = Marka;
            this.Kolor = Kolor;
            this.Rocznik=Rocznik;
        }

        public void wypisz()
        {
            Console.WriteLine("Samochód marki " + Marka + " jedzie z prędkością " + Predkosc);
            Console.WriteLine("Domyślna ilość kół używanych w samochodzie to " + LiczbaKol);
        }
    }
}
