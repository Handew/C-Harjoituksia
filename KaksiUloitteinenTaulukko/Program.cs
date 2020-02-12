using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaksiUloitteinenTaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean jatka = true;
            int i = 0;
            int laskuri = 0;
            String hakuPostinumero;
            string[,] henkiloTiedot = new string[100,5];

            while (jatka)
            {
                Console.Write("Anna etunimi (X=lopettaa):");
                henkiloTiedot[i,0] = Console.ReadLine();
                if (henkiloTiedot[i, 0].ToUpper() == "X")
                {
                    jatka = false;
                    break;
                }
                Console.Write("Anna sukunimi: ");
                henkiloTiedot[i, 1] = Console.ReadLine();
                Console.Write("Anna osoite: ");
                henkiloTiedot[i, 2] = Console.ReadLine();
                Console.Write("Anna postinumero: ");
                henkiloTiedot[i, 3] = Console.ReadLine();
                Console.Write("Anna postitoimipaikka: ");
                henkiloTiedot[i, 4] = Console.ReadLine();

                i++;
            }
            for (int j = 0; j < henkiloTiedot.GetLength(1); j++)
            {
                if (henkiloTiedot[j,0] != null)
                {
                    if (henkiloTiedot[j, 0].Length > 1)
                    {
                        Console.Write(henkiloTiedot[j, 0].PadRight(12).Substring(0,12) + " ");
                        Console.Write(henkiloTiedot[j, 1].PadRight(20).Substring(0, 20) + " ");
                        Console.Write(henkiloTiedot[j, 2].PadRight(30).Substring(0, 30) + " ");
                        Console.Write(henkiloTiedot[j, 3].PadRight(5).Substring(0, 5) + " ");
                        Console.WriteLine(henkiloTiedot[j, 4].PadRight(30).Substring(0, 30) + " ");
                    }
                }

            }
            Console.WriteLine("Postinumerohaku");
            Console.Write("Anna haettavien henkilöiden Postinumero: ");
            hakuPostinumero = Console.ReadLine();

            for (int k = 0; k < henkiloTiedot.GetLength(1); k++)
            {
                if(henkiloTiedot[k,3] == hakuPostinumero)
                {
                    Console.Write("Etunimi: " + henkiloTiedot[k, 0] + " Sukunimi: " + henkiloTiedot[k, 1] + " Osoite: " + henkiloTiedot[k, 2] + " Postinumero: " + henkiloTiedot[k, 3] + " Postitoimipaikka: " + henkiloTiedot[k, 4] + "\n");
                    laskuri++;
                }
            }
            Console.WriteLine("Henkilöhaku suoritettu, {0} riviä löydetty postinumerolla {1} !", laskuri.ToString(), hakuPostinumero);
            Console.WriteLine("Paina Enter sulkeaksesi ohjelman!");
            Console.ReadLine();

        }
    }
}
