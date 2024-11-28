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

            // girilen sayının faktoriyelini hesaplama

            Console.Write("lütfen faktoriyelini hesaplatmak istediğiniz sayıyı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = 1; 

            for( int i = 1; i<= sayi; i++)
            {
                sonuc *= i;
            }
            Console.WriteLine(sonuc);
        }
    }
}
