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
            int not = 0;
            int toplam = 0;
            int ort = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("not= ");
                not = Convert.ToInt32(Console.ReadLine());

                if (not > 0 && not <= 100)
                {
                    toplam += not;
                }
                else
                {
                    Console.WriteLine("tekrar deneyiniz.. not= ");
                }
            }

            ort = toplam / 20;
            Console.WriteLine("not ortalaması= " + ort);
        }
    }
}
