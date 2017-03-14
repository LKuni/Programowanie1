using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardowyCzlowiek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StandardowyCzlowiek> lista = new List<StandardowyCzlowiek>();
            StandardowyCzlowiek c1 = new StandardowyCzlowiek("Adam", 34, "USA");
            StandardowyCzlowiek c2 = new StandardowyCzlowiek("Zosia", 65, "Polska");
            StandardowyCzlowiek c3 = new StandardowyCzlowiek("Maja", 12, "Niemcy");
            StandardowyCzlowiek c4 = new StandardowyCzlowiek("Agnieszka", 23, "Austria");
            StandardowyCzlowiek c5 = new StandardowyCzlowiek("Krzyś", 76, "Kanada");
            lista.Add(c1);
            lista.Add(c2);
            lista.Add(c3);
            lista.Add(c4);
            lista.Add(c5);

            int wybor = -1;


            while (wybor != 0)
            {
                Console.WriteLine("Wybierz:");

                Console.WriteLine("0 - Wyjscie");
                Console.WriteLine("1 - Srednia wieku wszystkich obiektow.");
                Console.WriteLine("2 - Wszystkie imiona.");
                Console.WriteLine("3 - Uniwersalne dane standardowe czlowieka");
                Console.WriteLine("4 - Najczesciej wystepujace miejsce pochodzenia");

                wybor = Convert.ToInt32(Console.ReadLine());
                if (wybor == 1)
                {
                    
                    int suma = 0;
                    int wynik;
                    foreach (StandardowyCzlowiek czlowiek in lista)
                    {
                        suma += czlowiek.getWiek();
                    }
                    wynik = suma / lista.Count;
                    Console.WriteLine("Srednia wieku wynosi: {0}", wynik);
                }

                else if (wybor == 2)
                {
                    foreach (StandardowyCzlowiek czlowiek in lista)
                    {
                        Console.WriteLine(czlowiek.getImie());
                    }
                }

                else if (wybor == 3)
                {
                    Console.WriteLine("Ilosc kosci standardowego czlowieka to " + StandardowyCzlowiek.IloscKosci + ", a ilosc chomosomów to " + StandardowyCzlowiek.IloscChromosomow);

                }

                else if (wybor == 4)
                {
                    Dictionary<string, int> listaNajczestszych = new Dictionary<string, int>();
                    string miejscePochodzenia = "";
                    foreach (StandardowyCzlowiek czlowiek in lista)
                    {
                        miejscePochodzenia = czlowiek.getMiejscePochodzenia();
                        if (listaNajczestszych.Keys.Contains(miejscePochodzenia))
                        {
                            listaNajczestszych[miejscePochodzenia]++;

                        }
                        else
                        {
                            listaNajczestszych.Add(miejscePochodzenia, 1);
                        }
                    }
                    Console.WriteLine(listaNajczestszych.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);
                }

                else
                    Console.WriteLine("Zly wybor.");
            }
        }
    }
    
}
