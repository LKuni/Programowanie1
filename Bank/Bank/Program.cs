using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank konto1 = new Bank("Kinga Lemm", "546456", 50000);
            Bank konto2 = new Bank("Marian D", "856346", 15000);
            konto1.WplacPieniadze(200);
            konto1.SprawdzFundusze();
            konto1.ZmienFunduszeKonta(10);
            konto1.SprawdzFundusze();
            konto1.UsunKonto();

            konto2.Wyplacpieniadze(10000);
            konto2.WplacPieniadze(100);
            konto2.SprawdzFundusze();
            konto2.UsunKonto();

            Console.ReadKey();
        }
    }
}
