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
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi > max)
                {
                    max = sayi;
                }
                if (sayi < min)
                {
                    min = sayi;
                }
            }
            Console.WriteLine("en küçük sayı: " + min);
            Console.WriteLine("en büyük sayı: " + max);


            Console.ReadLine();
        }
    }
}
