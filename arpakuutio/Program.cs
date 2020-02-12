using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arpakuutio
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean lopeta = false;
            Console.WriteLine("Tervetuloa Yatzy-peliin!");
            while (lopeta != true)
            {
                Console.WriteLine("Heitetään noppaa");
                randomLuvut();
                Console.WriteLine("Heitetäänkö noppaa uudelleen? K=kyllä/E=ei");
                if (Console.ReadLine().ToUpper() == "E") lopeta = true;
            }
            
        }

        private static void randomLuvut()
        {
            int rLuku = 0;
            int i = 0;
            Random arpa = new Random();
            while (i < 5)
            {
                rLuku = arpa.Next(1, 7);
                Console.WriteLine("Nopan {1} silmäluku on  {0}", rLuku.ToString(), (i + 1).ToString());
                i++;
            }
        }
    }
}
