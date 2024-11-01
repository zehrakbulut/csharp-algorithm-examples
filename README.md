# Random Sayı Tahmin Oyunu

Kullanıcının 1-100 (1 ve 100 dahil) arasında rastgele bir sayı tahmin ettiği bir oyundur. Kullanıcıya toplamda 5 deneme hakkı verilmektedir.

## Oyun Kuralları

1. Rastgele bir sayı üretilir ve bu sayı bir değişkende saklanır.
2. Kullanıcı, 1-100 arası bir tahmin girer.
3. Kullanıcının toplamda 5 deneme hakkı vardır.
4. Her tahmin sonrası, kullanıcının tahmininin doğru olup olmadığı kontrol edilir:
   - Eğer tahmin doğruysa, "kazandınız" mesajı gösterilir ve oyun sona erer.
   - Eğer tahmin yanlışsa, kullanıcının tahmininin sayının altında mı yoksa üstünde mi olduğu bilgisi verilir.
5. Eğer kullanıcı 5 deneme hakkını da kullanırsa, oyun sona erer ve doğru sayı gösterilir.

## Kullanım

Aşağıdaki C# kodunu kullanarak oyunu çalıştırabilirsiniz:

```csharp
Random rastgele = new Random();
int sayi = rastgele.Next(1, 101);
int tahmin = 0;

Console.WriteLine("Akıldaki sayı sence ne?");

for (int i = 0; i < 5; i++)
{
    Console.Write("{0}. tahmin: ", i + 1);
    tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin == sayi)
    {
        Console.WriteLine("Kazandınız!");
        break;
    }
    else if (tahmin < sayi)
    {
        Console.WriteLine("Daha büyük.");
    }
    else
    {
        Console.WriteLine("Daha küçük.");
    }

    if (tahmin < 1 || tahmin > 100)
    {
        Console.WriteLine("Geçersiz tahmin. Lütfen 1 ile 100 arasında bir sayı giriniz.");
    }

    if (i == 4)
    {
        Console.WriteLine("Üzgünüm, deneme hakkınız bitti. Doğru sayı: " + sayi);
    }
}


