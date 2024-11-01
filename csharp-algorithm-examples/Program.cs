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
            int toplam = 0; int ortalama = 0;
            int sayi1, sayi2;

            Console.WriteLine("sayı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());


            if (sayi1 > sayi2)
            {
                int sayi = sayi1;
                sayi1 = sayi2;
                sayi2 = sayi;
            }

            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam += i;
            }

            Console.WriteLine("toplam= " + toplam);
            ortalama = toplam / (sayi2 - sayi1);
            Console.WriteLine("ortalama= " + ortalama);
        }
    }
}
