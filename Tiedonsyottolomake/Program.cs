using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiedonsyottolomake
{
    class Program
    {
        static void Main(string[] args)
        {
            string etunimi = "";
            string sukunimi = "";
            string osoite = "";
            string postitoimipaikka = "";
            string postinumero = "";
            string puhelinnumero = "";
            string sahkoposti = "";
            int maara = 0;

            Console.Write("Etunimi: ");
            etunimi = Console.ReadLine();
            Console.Write("Sukunimi: ");
            sukunimi = Console.ReadLine();
            Console.Write("Osoite: ");
            osoite = Console.ReadLine();
            Console.Write("Postitoimipaikka: ");
            postitoimipaikka = Console.ReadLine();
            Console.Write("Postinumero: ");
            postinumero = Console.ReadLine();
            Console.Write("Puhelinnumero: ");
            puhelinnumero = Console.ReadLine();
            Console.Write("Sähköposti: ");
            sahkoposti = Console.ReadLine();

            maara = etunimi.Length + sukunimi.Length + osoite.Trim().Length + postinumero.Length + postitoimipaikka.Length + puhelinnumero.Length + sahkoposti.Length;

            Console.WriteLine(etunimi + " " + sukunimi + "\n"
                                + osoite + "\n" + postinumero + " " + postitoimipaikka + "\n"
                                + puhelinnumero + "\n" +
                                sahkoposti + "\nsyötettyjen merkkien määrä oli: " +maara);



            Console.ReadLine();
        }
    }
}
