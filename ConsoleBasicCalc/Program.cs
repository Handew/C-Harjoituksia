using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double dSumma = 0;
            string strSumma = "";
            string luku = "0";

            while (luku.Length > 0)
            {
                dSumma = dSumma + Double.Parse(luku);
                Console.Write("Anna luku ({0}): ",dSumma.ToString());
                luku = Console.ReadLine();
            }
            Console.WriteLine("Lukujen summa on " +dSumma.ToString());
            Console.WriteLine();
            Console.Write("Paina enter lopettaaksesi!");
            Console.ReadLine();

        }
    }
}
