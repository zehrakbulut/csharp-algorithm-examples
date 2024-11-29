using System;
using System.Collections;
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
            // decimal to binary...

            Console.Write("lütfen sayı giriniz: ");
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();  //sayıları liste

            if(int.TryParse(input, out int sayi))
            {
                int bolum=1;
                int kalan;

                while (bolum != 0)
                {
                    bolum = sayi / 2;
                    kalan = sayi % 2;

                    sayi = bolum;

                    numbers.Add(kalan);
                }
            }

            else
            {
                Console.Write("geçersiz giriş..");
            }

            for (int i = numbers.Count() - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
