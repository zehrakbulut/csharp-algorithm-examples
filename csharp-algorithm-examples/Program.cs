using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_algorithm_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //beden kitle indeksi = kilo/(boy*boy)
            //beden kitle indeksi 18'e eşit veya düşükse zayıf
            //18 ile 25 arasındaysa normal
            //25'ten büyükse obez yazdıran program parçasını kodlayınız

            double boy = 0;
            double kilo = 0;
            bool flagBoy = true;
            bool flagKilo = true;

            while (flagBoy)
            {
                Console.Write("lütfen boyunuzu giriniz: ");
                if (double.TryParse(Console.ReadLine(), out boy) && boy > 0)
                {
                    flagBoy = false;
                }
                else
                {
                    Console.WriteLine("hatalı giriş..");
                }
            }

            while (flagKilo)
            {
                Console.Write("lütfen kilonuzu giriniz: ");
                if (double.TryParse(Console.ReadLine(), out kilo) && kilo > 0)
                {
                    flagKilo = false;
                }
                else
                {
                    Console.WriteLine("hatalı giriş..");
                }
            }

            double bki = kilo / (boy * boy);
            Console.Write("boy kütle indeksiniz: " + bki);

            if (bki < 18)
            {
                Console.WriteLine("ZAYIF");
            }
            else if (bki > 18 && bki < 25)
            {
                Console.WriteLine("ORTA");
            }
            else
            {
                Console.WriteLine("KİLOLU");
            }
        }
    }
}
