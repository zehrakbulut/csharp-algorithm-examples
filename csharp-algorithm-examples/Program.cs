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
            int sayi = 0;
            int toplam = 0;

            while (toplam <= 50)
            {
                Console.WriteLine("sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine("toplam= " + toplam);
            Console.ReadLine();
        }
    }
}
