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


          

            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 11);

            Console.WriteLine("aklımdaki sayı sence ne? " + sayi);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("tahmininizi giriniz: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == sayi)
                {
                    Console.WriteLine("kazandınız");
                    break;
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("daha küçük");
                }
                else
                {
                    Console.WriteLine("daha büyük");
                }

                if (tahmin < 0 || tahmin > 101)
                {
                    Console.WriteLine("geçersiz tahmin");
                }
            }
        }
    }
}
