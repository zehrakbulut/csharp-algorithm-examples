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
            Console.Write("bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while( sayi != 0)
            {
                sum = sum + sayi % 10;
                sayi = sayi / 10;
            }
            Console.WriteLine("rakamları toplamı = "+sum);
        }
    }
}
