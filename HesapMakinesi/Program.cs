using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sonuc = 1;


            Console.WriteLine("Birinci sayıyı giriniz:");
            double birinci = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            double ikinci = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapılacak işlemi seçiniz(*/-+):");
            string islem = Console.ReadLine();


            if (islem == "*")
            {
                sonuc = birinci * ikinci;
            }
            else if (islem == "/")
            {
                sonuc = birinci / ikinci;
            }
            else if (islem == "+")
            {
                sonuc = birinci + ikinci;
            }
            else if (islem == "-")
            {
                sonuc = birinci - ikinci;
            }
            else
            {
                Console.WriteLine("yanlış işlem seçtiniz.");
                Console.ReadLine();
            }


            Console.WriteLine("işlemin sonucu: " + sonuc);
            Console.ReadLine();

        }
    }
}
