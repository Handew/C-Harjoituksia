using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikalaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region     // 1. Harjoitus - Aikaero päivissä

            //Double aikaEro = 0;
            //string syntymaAika = "";
            //DateTime syntymaAikaDT;
            //DateTime tanaan = DateTime.Today;

            //Console.Write("Anna syntymäaikasi muodossa PP.KK.VVVV: ");
            //syntymaAika = Console.ReadLine();

            //syntymaAikaDT = DateTime.Parse(syntymaAika);
            //aikaEro = tanaan.Subtract(syntymaAikaDT).Days;


            //Console.WriteLine("Sinulla on ikää " +aikaEro+ " päivää.\n");
            //Console.Write("Paina enter lopettaaksesi");
            //Console.ReadLine();

            #endregion

            #region     // 2. Harjoitus - Aikaero tunneissa

            //Double aikaEro = 0;
            //string alkuAika = "";
            //DateTime syntymaAikaDT;
            //string formaatti = "dd.MM.yyyy";
            //DateTime tanaan = DateTime.Now;
            //CultureInfo kulttuuri = CultureInfo.InvariantCulture;

            //Console.Write("Anna syntymäaikasi muodossa PP.KK.VVVV: ");
            //alkuAika = Console.ReadLine();

            //syntymaAikaDT = DateTime.ParseExact(alkuAika, formaatti, kulttuuri);
            //aikaEro = tanaan.Subtract(syntymaAikaDT).TotalHours;

            //aikaEro = Math.Round(aikaEro, 2);
            //Console.WriteLine("PVM / aikaerotus on " + aikaEro.ToString() + " tuntia.\n");
            //Console.Write("Paina enter lopettaaksesi");
            //Console.ReadLine();

            #endregion

            #region     // 3. Harjoitus

            Boolean ulos = false;
            while (ulos != true)
            {
                Console.WriteLine("Eliniänodote laskuri");
                elinIanOdote();
                Console.WriteLine("Haluatko jatkaa?  E=exit");
                string luku = Console.ReadLine().ToUpper();
                if (luku == "E") ulos = true;
            }
            

            #endregion
        }

        private static void elinIanOdote()
        {
            int elinIanOdote = 0;
            Double aikaJaljella = 0;
            string alkuAika = "", sp = "";
            string vuodetKuukaudetPaivat = "";
            DateTime syntymaAikaDT, elinianOdotusDT;
            string formaatti = "dd.MM.yyyy";
            DateTime tanaan = DateTime.Today;
            CultureInfo kulttuuri = CultureInfo.InvariantCulture;

            Console.WriteLine("Kerro sukupuoli, M=Mies/N=Nainen");
            sp = Console.ReadLine().ToUpper();
            switch (sp)
            {
                case "M":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    elinIanOdote = 78;
                    break;
                case "N":
                    Console.BackgroundColor = ConsoleColor.Red;
                    elinIanOdote = 84;
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta!");
                    elinIanOdote = 0;
                    break;
            }

            Console.Write("Anna syntymäaika muodossa PP.KK.VVVV: ");
            alkuAika = Console.ReadLine();

            try
            {
                syntymaAikaDT = DateTime.ParseExact(alkuAika, formaatti, kulttuuri);
                elinianOdotusDT = syntymaAikaDT.AddYears(elinIanOdote);
                aikaJaljella = elinianOdotusDT.Subtract(tanaan).TotalDays;
                DateTime paivat = new DateTime(new TimeSpan((int)aikaJaljella + 1, 0, 0, 0).Ticks);
                vuodetKuukaudetPaivat = string.Format("{0} vuotta {1} kuukautta ja {2} päivää", paivat.Year - 1, paivat.Month - 1, paivat.Day - 1);

                if(paivat.Year > 20)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                } else if(paivat.Year < 20 && paivat.Year > 2)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                } else if (paivat.Year <= 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep(800, 200);
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine("Ohjelma ei osannut laskea päivämääräerotusta. Tarkasta pvm-formaatti!");
                Console.WriteLine(ee.Message);
                aikaJaljella = 0;
            }

            Console.WriteLine("Odotettua elinaikaa jäljellä " + vuodetKuukaudetPaivat + ".\n");
            Console.ResetColor();


            //Console.Write("Paina enter lopettaaksesi");
            //Console.ReadLine();
        }
    }
}
