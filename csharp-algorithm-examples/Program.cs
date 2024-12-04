using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_algorithm_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lütfen pozitif bir tamsayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool katiMi = false;
            if(sayi > 0)
            {
                if(sayi % 3 == 0 || sayi % 7 == 0)
                {
                    katiMi = true;
                    Console.WriteLine(katiMi);
                }
                else
                {
                    Console.WriteLine(katiMi);
                }
            }
            else
            {
                Console.Write("lütfen 0'dan büyük bir tamsayı giriniz..");
            }
        }
    }
}
