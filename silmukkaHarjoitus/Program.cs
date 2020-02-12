using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silmukkaHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();

            int j = 0;
            while (j<0)
            {
                Console.WriteLine(j.ToString());
                j++;
            }
            Console.ReadLine();

            int k = 0;
            do
            {
                Console.WriteLine(k.ToString());
                k++;
            } while (k<0);
            Console.ReadLine();
        }
    }
}
