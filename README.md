# Sıfırdan Sonsuz Döngü ile Tahmin Oyunu

Bu program, kullanıcının rastgele bir sayıyı tahmin etmeye çalıştığı bir oyunu içermektedir. Aşağıda oyunun detayları ve kuralları yer almaktadır.

## Soru-2

Bir tahmin oyunu oluşturun. Öncelikle rastgele bir sayı üretin ve bu sayıyı bir değişkende tutun. Kullanıcı 1-100 (1 ve 100 dahil) arası tahmin edecek. Bu defa tahmin kısıtlaması yok. Her tahmin sonucu sayının küçük veya büyük olduğu bilgisi kullanıcıya verilsin. Kullanıcı doğru sayıyı tahmin ederse oyun sonlansın.

## Oyun Kuralları

- Kullanıcı, rastgele üretilen bir sayıyı tahmin etmeye çalışır.
- Her tahmin sonucunda kullanıcıya sayının küçük veya büyük olduğu bilgisi verilir.
- Kullanıcı doğru tahmini yaptığında oyun sona erer.
- Tahmin aralığı 1 ile 100 arasındadır (dışında kalan tahminler geçersiz sayılır).

## Kod

Aşağıda oyunun implementasyonu bulunmaktadır:

```csharp
using System;

namespace csharp_algorithm_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 101); // 1-100 arasında rastgele bir sayı üretir.

            int tahmin = 0;

            Console.WriteLine("Sayı tahmin oyunu başlasın!");

            while (tahmin != sayi)
            {
                Console.Write("Tahmininizi giriniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == sayi)
                {
                    Console.WriteLine("Kazandınız!");
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin.");
                }

                if (tahmin < 1 || tahmin > 100)
                {
                    Console.WriteLine("Geçersiz tahmin. Lütfen 1 ile 100 arasında bir sayı giriniz.");
                }
            }
        }
    }
}
