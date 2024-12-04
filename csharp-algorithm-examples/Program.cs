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
            //Bir tamsayı dizisinin tüm elemanlarının toplamını hesaplayan bir C# programı yazın.

            int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;
            for(int i = 0; i<array1.Length; i++)
            {
                sum += array1[i];
            }
            Console.WriteLine(sum);
        }
    }
}
