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
            //santigrat'ı kelvine ve fahrenheit'e çevirme

            Console.Write("hava kaç °C: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} + (273,15) = {1}K ", celsius, (celsius + 273, 15));
            Console.WriteLine("{0} * 1.8 + 32  = {1}°F ", celsius, (celsius * 18/10 + 32));
        }
    }
}
