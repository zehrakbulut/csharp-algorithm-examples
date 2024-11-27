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
         
            for(int i = 1; i<=100; i++)
            {
                bool asalMi = true;

                if(i == 1)
                {
                    continue;
                }

                for(int j = 1; j<i; j++)
                {
                    if(j == 1)
                    {
                        continue;
                    }

                    else if(i % j == 0)
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
