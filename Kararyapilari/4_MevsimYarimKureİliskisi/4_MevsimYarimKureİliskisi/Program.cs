using System;

namespace _4_MevsimYarimKureİliskisi
{
    class Program
    {
        // Hangi aydayız Girilir
        // Hangi Yarım Küredeyiz Girilir (G: Güney Yarım Küre K: Kuzey Yarım Küre)
        // 
        // 12 1 2  K girilmiş ise Aralık Ocak Şubat kış mevsimindeyiz yazılır
        // 3 4 5 K girilmiş ise ilkbahar mevsimindeyiz yazılır
        // 6 7 8 K  girilmiş ise  yaz mevsimindeyiz yazılır
        // 9 10 11 K girilmiş ise Sonbahar mevsimindeyiz yazılır
        // 
        // 12 1 2  G girilmiş ise Aralık Ocak Şubat yaz mevsimindeyiz yazılır
        // 3 4 5 G girilmiş ise Sonbahar mevsimindeyiz yazılır
        // 6 7 8 G  girilmiş ise  Kış mevsimindeyiz yazılır
        // 9 10 11 G girilmiş ise İlkbahar mevsimindeyiz yazılır

        static void Main(string[] args)
        {
            int ay = AyAl();
            string hangiKure = KureAl();
            SonucYaz(ay,hangiKure);
        }

        private static string KureAl()
        {
            Console.WriteLine("Kaçıncı Kürediyiz K: Kuzey G: Güney");
            return (Console.ReadLine());
        }

        private static void SonucYaz(int ay, string kure)
        {
            // Buraya Kodunuzu Yazın
            if (kure == "K")
            {
                if (ay == 12 || ay == 1 || ay == 2    )
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
            else if (kure == "G")
            {
                if (ay == 12 || ay == 1 || ay == 2)
                {
                    Console.WriteLine("Yaz Mevsimindeyiz");
                }
                else if (ay == 3 || ay == 4 || ay == 5)
                {
                    Console.WriteLine("Sonbabar Mevsimindeyiz");
                }
                else if (ay == 6 || ay == 7 || ay == 8)
                {
                    Console.WriteLine("Kış Mevsimindeyiz");
                }
                else if (ay == 9 || ay == 10 || ay == 11)
                {
                    Console.WriteLine("İlkbahar Mevsimindeyiz");
                }
                else
                {
                    Console.WriteLine("Yanlış Ay Girdiniz");
                }
            }
            else
            {
                Console.WriteLine("Yanlış Küre Kodu Girdiniz ...");
            }
           

        }

        private static int AyAl()
        {
            Console.WriteLine("Kaçıncı aydayız");
            return Convert.ToInt32((Console.ReadLine()));
        }
    }
}
