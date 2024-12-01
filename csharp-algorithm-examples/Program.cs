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
            // sessiz harfleri yazdırma...

                Console.WriteLine("lütfen bir kelime giriniz: ");
            string kelime = Console.ReadLine();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            
            foreach (char harf in sesliHarfler)
            {
                kelime = kelime.ToLower().Replace(harf.ToString(), "");
            }
            Console.WriteLine(kelime);

            Console.Read();
        }
    }
}
