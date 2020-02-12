using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksiuloitteinenTaulukkoNimiKyselylla
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean jatka = true;
            int i = 0;
            string[] nimet = new string[100];

            while (jatka)
            {
                Console.Write("Anna etunimi (X=lopettaa):");
                nimet[i] = Console.ReadLine();    
                if (nimet[i].ToUpper() == "X") jatka = false;
                i++;
            }
            for (int j = 0; j < nimet.Length; j++)
            {
                if(nimet[j] != null)
                {
                    if(nimet[j].Length > 1) Console.WriteLine(nimet[j]);
                }
                
            }
            Console.WriteLine("Paina Enter sulkeaksesi ohjelman!");
            Console.ReadLine();

        }
    }
}
