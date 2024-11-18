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
            //1
            //kullanıcıya sorucaz nasıl bir işlem yapmak istediğini
            //1 - bakiye görüntüleme
            //2 - para çekme
            //3 - para yatırma
            //q ya basarsa -çıkış yapma
            {




                int bakiye = 1000;

                Console.WriteLine("yapılıcak işlemi seçiniz: ");
                Console.WriteLine("1-bakiye görüntüleme");
                Console.WriteLine("2-para çekme");
                Console.WriteLine("3-para yatırma");
                Console.WriteLine("q ya basarsa çıkış yapma");

                string islem = Console.ReadLine();

                switch (islem)
                {
                    case "1":
                        Console.WriteLine("bakiye: " + bakiye);
                        break;

                    case "2":
                        Console.Write("çekmek istediğiniz tutar: ");
                        int cekilicekTutar = int.Parse(Console.ReadLine());
                        if (cekilicekTutar < bakiye)
                        {
                            Console.WriteLine("kalan bakiye: " + (bakiye - cekilicekTutar));
                        }
                        else
                        {
                            Console.WriteLine("yetersiz bakiye!!!");
                        }
                        break;

                    case "3":
                        Console.Write("yatırmak istediğiniz tutar: ");
                        int yatirilicakTutar = int.Parse(Console.ReadLine());
                        Console.WriteLine("yeni bakiye: " + (bakiye + yatirilicakTutar));
                        break;

                    case "q":
                        Console.WriteLine("çıkış yapılıyor");
                        break;

                    default:
                        Console.WriteLine("geçersiz tuşlama...");
                        break;


                }

            }
        }
    }
}
