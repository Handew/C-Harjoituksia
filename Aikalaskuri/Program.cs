using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aikalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime eka = new DateTime();
            DateTime toka = new DateTime();
            string ekaDT = "";
            string tokaDT = "";

            Console.WriteLine("Kerro ensimmäinen päivämäärä: PP.KK.VVVV");
            ekaDT = Console.ReadLine();
            eka = DateTime.Parse(ekaDT);
            Console.WriteLine("Kerro toinen päivämäärä: PP.KK.VVVV");
            tokaDT = Console.ReadLine();
            toka = DateTime.Parse(tokaDT);

            Double erotus = 0;
            erotus = toka.Subtract(eka).TotalMinutes;

            Console.WriteLine("Päivämäärien erotus " +erotus+ " minuuttia.");
            Console.ReadLine();
        }
    }
}
