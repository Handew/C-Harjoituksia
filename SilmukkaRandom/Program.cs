using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilmukkaRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean exit = false;
            
            Console.WriteLine("Tervetuloa automaattiseen arvauspeliin!");
            
            while (exit == false)
            {
                arvausPeli();
                Console.WriteLine("Haluatko uuden kierroksen? K/E");
                string luettu = Console.ReadLine().ToUpper();
                if(luettu == "E")
                {
                    exit = true;
                }
            }
            

        }

        private static void arvausPeli()
        {
            Random rnd = new Random();
            int rLuku = rnd.Next(1, 3001);
            int i = 0;
            Boolean exit = false;

            while (exit == false)
            {
                int arvaus = rnd.Next(1, 3001);
                if (arvaus == rLuku)
                {
                    Console.WriteLine("Oikea luku löytynyt! Tähän meni {0} kierrosta!!!", i);
                    exit = true;
                }
                i++;
            }
        }
    }
}
