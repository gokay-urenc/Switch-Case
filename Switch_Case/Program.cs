using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 1;
               switch (x)  Kontrol edilecek değer.
               {
                   case 1:  Koşul ve altındada koşul kodları.
                       break;  Koşulun bittiğini belirtir.
                   case 2:
                       break;
                   case 3:
                       break;
                   default:  If - Else yapısındaki else'dir.
                       break;
               } */
            // Kullanıcıdan alınan sayının harf karşılığını gösteren program.
            Console.Write("0 ile 9 arasında bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 0:
                    Console.Write("Sıfır");
                    break;
                case 1:
                    Console.Write("Bir");
                    break;
                case 2:
                    Console.Write("İki");
                    break;
                case 3:
                    Console.Write("Üç");
                    break;
                case 4:
                    Console.Write("Dört");
                    break;
                case 5:
                    Console.Write("Beş");
                    break;
                case 6:
                    Console.Write("Altı");
                    break;
                case 7:
                    Console.Write("Yedi");
                    break;
                case 8:
                    Console.Write("Sekiz");
                    break;
                case 9:
                    Console.Write("Dokuz");
                    break;
                default:
                    Console.Write("Geçersiz değer.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
/* Switch - Case bloğu If - Else mantığı ile çalışan bir kontrol mekanizmasıdır. Aradaki fark; If - Else yapısı büyüklük küçüklük gibi durumları kontrol     ederken, switch - case sadece koşulun eşitlik durumunu kontrol eder. Bu yapıda her zaman bir değer kontrol edilir. 
   Switch - case sadece eşitliği kontrol eder. If - Else mantığında ise bütün ihtimalleri sırayla kontrol eder. O yüzden switch - case daha performanslıdır.
   Fakat if - else yapısı kadar esnek değildir. Her bir case tek bir koşul içerir.
*/
