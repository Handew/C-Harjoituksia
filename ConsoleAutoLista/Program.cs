using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAutoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string auto = "";
            List<string> Autot = new List<string>();

            Console.Write("Anna autojen merkit tai x lopettaaksesi: ");

            while (auto.ToUpper() != "X")
            {
                Console.Write("Auton merkki: ");
                auto = Console.ReadLine();
                if(auto.ToUpper() != "X")
                {
                    Autot.Add(auto);
                }
            }

            Autot.Sort();

            Console.WriteLine("Tallensit nämä autot: ");

            for (int i = 0; i < Autot.Count; i++)
            {
                Console.WriteLine(Autot[i]);
            }
            Console.ReadLine();
        }
    }
}
