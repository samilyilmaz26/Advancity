using System;

namespace _2_HangiGun
{
    class Program
    {
        // Biraz daha Karmaşık karar yapısı 
        // Ekrandan kaçıncı gün olduğu girilir
        // Girilen güne göre sonuç Pazartesi ... Pazar gibi cevap alınır.
        static void Main(string[] args)
        {
            int gun = GunAl();
            SonucYaz(gun);
        }

        private static void SonucYaz(int gun)
        {
            // Buraya Kod Yazın 
            if (gun == 1)
            {
                Console.WriteLine("Bugün Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Bugün Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Bugün Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Bugün Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Bugün Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Bugün Cumartesi");
            }
            else if (gun == 7)
            {
                Console.WriteLine("Bugün Pazar");
            }
            else
            {
                Console.WriteLine("Yanlış Sayı Girdiniz");
            }
        }

        private static int GunAl()
        {
            Console.WriteLine("Bugün Kaçıncı Gündeyiz");
            return Convert.ToInt32((Console.ReadLine()));
        }
    }
}
