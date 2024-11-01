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


          //Soru: bir tahmin oyunu oluşturmanı istiyorum.Öncelikle random bir sayı üretilsin
          //ve bu bir değişkende tutulsun. Kullanıcı 1 - 100(1 ve 100 dahil) arası tahmin edecek
          //ve toplamda 5 deneme hakkı olacak.Eğer deneme hakkı biterse oyun sonlanacak. 
          //Her tahmin sonucu sayının küçük büyük olduğu bilgisi kullanıcıya verilsin. Kullanıcı
          //doğru sayıyı tahmin ederse oyun sonlansın.

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
