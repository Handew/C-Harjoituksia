using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rLuku = rnd.Next(0,100);
            int arvaus;
            List<int> Lista = new List<int>();
            Boolean exit = false;

            while (exit == false)                               //Silmukka alkaa
            {
                Console.WriteLine("Arvaa luku: ");
                arvaus = int.Parse(Console.ReadLine());
                Lista.Add(arvaus);                              //lisätään arvaus talteen

                if(arvaus == rLuku)                             //Katsotaan onko arvaus oikein
                {
                    Console.WriteLine("Arvasit oikein! Sinulla meni tähän {0} arvausta!", Lista.Count);
                    Console.Write("Arvasit seuraavat luvut: ");
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        Console.Write(Lista[i] + " ");
                    }
                    exit = true;                                //Päästää ulos silmukasta
                }
                if (arvaus < rLuku) Console.WriteLine("Luku on suurempi!");    
                if (arvaus > rLuku) Console.WriteLine("Luku on pienempi!");
                
            }
            Console.ReadLine();
        }
    }
}
