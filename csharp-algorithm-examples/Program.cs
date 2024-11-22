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

            //1-100 asal sayıları yazdırma

            for (int i =2;  i<100; i++)
            {
                bool asalMi = true;

                for (int j =2; j<i; j++)
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
