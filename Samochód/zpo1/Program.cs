using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zpo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Samochod> Lista = new List<Samochod>();

            Samochod jeden = new Samochod(4, "Suzuki");
            jeden.Jedz(34.5);
            Samochod dwa = new Samochod(4, "Honda");
            dwa.Jedz(76);
            dwa.Hamuj();
            Samochod trzy = new Samochod(4, "Ford", "Czerwony", 2001);
            trzy.Jedz(100);

            Lista.Add(jeden);
            Lista.Add(dwa);
            Lista.Add(trzy);

            foreach (Samochod s in Lista)
            {
                s.wypisz();
            }


            Console.ReadKey();
        }
    }
}
