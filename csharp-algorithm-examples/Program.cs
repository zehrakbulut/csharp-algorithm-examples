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

            int i = 0;
            int tahmin = 0;
            Console.WriteLine("sayı tahmin oyunu başlasın");
            Console.WriteLine(sayi);

            while (tahmin != sayi)
            {
                i++;
                Console.Write("{0} .tahmin: ", i);
                tahmin = Convert.ToInt32(Console.ReadLine()); 
                if (tahmin == sayi)
                {
                    Console.WriteLine("kazandınız");
                    return;
                    //Environment.Exit(0);  //buda olabilir
                }
                else if (tahmin < sayi)

                {
                    Console.Write("daha büyük.. ");
                }
                else
                {
                    Console.Write("daha küçük..");
                }
                if (tahmin < 0 || tahmin > 100)
                {
                    Console.WriteLine("girdiğiniz sayı geçersizdir..");
                }
            }


            Console.ReadLine();
        }
    }
}
