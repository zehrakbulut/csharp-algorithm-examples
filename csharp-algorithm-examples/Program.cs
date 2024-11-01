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
            int toplam = 0;
            int kare = 0;
            int sayi = 0;
            int adet = 0;

            Console.WriteLine("kaç tane sayı girmek istersiniz: ");
            adet = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("bir sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                kare = sayi * sayi;
                toplam = toplam + kare;
            }
            Console.WriteLine("toplam= " + toplam);
            Console.ReadLine();
        }
    }
}
