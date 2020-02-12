using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennusSofta
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "C:\\Users\\Hannu\\Documents\\Downloads\\Lampotila.txt";
            string aikaisempiArvo, uusiArvo;

            if (File.Exists(tiedosto))
            {
                aikaisempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Lämpötila on: {0} astetta", aikaisempiArvo);
            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }
            Console.Write("Anna uusi lämpötila: ");
            uusiArvo = Console.ReadLine();
            // Tiedostoon kirjoittaminen
            File.WriteAllText(tiedosto, uusiArvo);
            Console.WriteLine("Uusi arvo tallennettu!");
            Console.ReadLine();
        }
    }
}
