using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_algorithm_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int sayac = 0;

            while (sayi != 0)
            {
                toplam += sayi;
                sayac++;

                Console.WriteLine("Sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
            }

            if (sayac > 0)
            {
                Console.WriteLine("Girilen sayıların toplamı={0} Ortalaması={1}", toplam, toplam / sayac);
            }
            else
            {
                Console.WriteLine("sayı girilmedi");
            }

            Console.ReadKey();
        }
    }
}
