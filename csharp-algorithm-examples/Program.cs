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
            //Bir dizenin belirtilen bir kelime ile başlayıp başlamadığını kontrol eden bir C# programı yazın.

            string kelime = "Merhaba";

            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cumle = Console.ReadLine();

            bool varMi = false;

            //if (cumle.Length < 8 && cumle.Equals("Merhaba") || cumle.StartsWith("Merhaba") && cumle[7] == ' ')
            if (cumle.Contains(kelime))
            {
                varMi = true;
                Console.WriteLine(varMi);
            }
            else
            {
                Console.WriteLine(varMi);
            }
        }
    }
}
