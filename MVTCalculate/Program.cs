using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtv_console
{
    class Program
    {
        static void Main(string[] args)
        {
            double tutar = 0;
            int secim1, secim2, secim3;
            Console.WriteLine("Araç Türü : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - Binek Araç");
            Console.WriteLine("(2) - Ticari Araç");
            Console.Write("Seçim Yapın (1)-(2) : ");
            secim1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();//www.yazilimkodlama.com
            Console.WriteLine("Araç Yaşı : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - 1-3 Yaş");
            Console.WriteLine("(2) - 4-7 Yaş");
            Console.WriteLine("(3) - 7 Yaş Üzeri");
            Console.Write("Seçim Yapın (1)-(2)-(3) : ");
            secim2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Motor Hacmi : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - 0-1300");
            Console.WriteLine("(2) - 1300-1600");//www.yazilimkodlama.com
            Console.WriteLine("(3) - 1600-2000");
            Console.WriteLine("(4) - 2000 Üzeri");
            Console.Write("Seçim Yapın (1)-(2)-(3) : ");
            secim3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (secim1 == 1)
            {
                tutar = 100;
            }
            else if (secim1 == 2)
            {
                tutar = 150;
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                tutar = 0;
            }
            if (secim2 == 1)
            {
                tutar = tutar * 1.75;
            }
            else if (secim2 == 2)
            {
                tutar = tutar * 1.5;
            }
            else if (secim2 == 3)
            {
                tutar = tutar * 1.25;
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                tutar = 0;
            }
            ///www.yazilimkodlama.com
            if (secim3 == 1)
            {
                tutar *= 2;
            }
            else if (secim3 == 2)
            {
                tutar *= 3;
            }
            else if (secim3 == 3)
            {
                tutar *= 4;
            }
            else if (secim3 == 4)
            {
                tutar *= 5;
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                tutar = 0;
            }

            Console.WriteLine("===============================");
            Console.WriteLine("Ödenecek Tutar : {0}", tutar);
            Console.ReadKey();
        }
    }
}