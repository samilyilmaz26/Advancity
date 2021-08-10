using System;

namespace _3_HangiMevsim
{
    class Program
    {
        // Hangi aydayız Girilir
        // 12 1 2  girilmiş ise Aralık Ocak Şubat kış mevsimindeyiz yazılır
        // 3 4 5 girilmiş ise ilkbahar mevsimindeyiz yazılır
        // 6 7 8 girilmiş ise  yaz mevsimindeyiz yazılır
        // 9 10 11 girilmiş ise Sonbahar  mevsimindeyiz yazılır

        static void Main(string[] args)
        {
            int ay = AyAl();
            SonucYaz(ay);
        }

        private static void SonucYaz(int ay)
        {
            // Buraya Kodunuzu Yazın
            if (ay == 12 || ay == 1  || ay == 2 )
            {
                Console.WriteLine("Kış Mevsimindeyiz");
            }
            else if (ay == 3 || ay == 4 || ay == 5)
            {
                Console.WriteLine("İlkbahar Mevsimindeyiz");
            }
            else if (ay == 6 || ay == 7 || ay == 8)
            {
                Console.WriteLine("Yaz Mevsimindeyiz");
            }
            else if (ay == 9 || ay == 10 || ay == 11)
            {
                Console.WriteLine("Sonbahar Mevsimindeyiz");
            }
            else
            {
                Console.WriteLine("Yanlış Ay Girdiniz");
            }

        }

        private static int AyAl()
        {
            Console.WriteLine("Kaçıncı aydayız");
            return Convert.ToInt32((Console.ReadLine()));
        }
    }
}
