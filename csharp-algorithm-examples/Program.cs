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

            Console.WriteLine("bir sayi giriniz: ");
            int girdi = int.Parse(Console.ReadLine());

            bool asalMi = true;

            for(int i=2; i<=girdi; i++)
            {
                if (girdi % i == 0)
                {
                    asalMi = false;
                    Console.WriteLine("Girmiş olduğunuz sayı ASAL DİĞİL.");
                    break;
                }
                else
                {
                    Console.WriteLine("Girmiş olduğunuz sayı ASAL.");
                    break;
                }
            }          
        }
    }
}
