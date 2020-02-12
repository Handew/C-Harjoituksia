using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yksiUloitteinenTaulukku
{
    class Program
    {
        static void Main(string[] args)
        {
            string luku;
            int iLuku, laskuri = 0;
            bool success, löytyi;
            int[] taulukko1 = new int[] { 1, 3, 5, 16, 77, 101 };

            Console.WriteLine("Anna luku, niin etsin onko se taulukossa: ");
            luku = Console.ReadLine();
            if(!int.TryParse(luku, out iLuku) == true)
            {
                Console.WriteLine("Luku ei ollut numeerinen");
            }
            löytyi = false;
            for (int i = 0; i < taulukko1.Length; i++)
            {
                if(iLuku == taulukko1[i])
                {
                    Console.WriteLine("Onneksi olkoon, luku {0} löytyi!", iLuku.ToString());
                    löytyi = true;
                }
                laskuri = i+1;
            }
            if (löytyi == false) Console.WriteLine("Kävin läpi {0} lukua, mutten löytänyt lukua {1}!", laskuri.ToString(), iLuku.ToString());

            Console.WriteLine("Paina Enter...");
            Console.ReadLine();
        }
    }
}
