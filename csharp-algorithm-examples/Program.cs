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

            Console.Write("lütfen bir sayı giriniz: ");
            int girilen = int.Parse(Console.ReadLine());

            for(int i = 2; i<= girilen; i++)
            {
                bool asalMi = true;

                for(int j = 2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }

                if (asalMi)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
