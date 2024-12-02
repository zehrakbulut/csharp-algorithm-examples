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

            Console.Write("birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            bool kontrol = false;
            if(sayi1<0 && sayi2>0 || sayi1>0 && sayi2 < 0)
            {
                kontrol = true;
                Console.WriteLine(kontrol);
            }
            else
            {
                Console.WriteLine(kontrol);
            }
        }
    }
}
