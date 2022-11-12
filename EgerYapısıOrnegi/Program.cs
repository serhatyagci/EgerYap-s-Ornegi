using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgerYapısıOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. notunuzu giriniz");
            int birinci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. notunuzu giriniz");
            int ikinci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 3. notunuzu giriniz");
            int ucuncu = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci + ikinci + ucuncu) / 3;

            if (sonuc >= 80 && sonuc < 100)
            {
                Console.WriteLine("Not değeriniz : A+");
            }

            else if (sonuc >= 60)
            {
                Console.WriteLine("Not değeriniz : A");
            }

            else if (sonuc >= 40)
            {
                Console.WriteLine("Not değeriniz : B+");
            }

            else
            {
                Console.WriteLine("Not değeriniz : Nanay");
            }

            Console.ReadLine();
        }
    }
}
