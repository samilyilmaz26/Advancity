using System;

namespace _1_Basicif
{
    class Program
    {
        // if  doğru kullanıldğını ölçen proje
        // Kahveye Giriş için 18 yaş ve üstünü kontrol edip karar verir
        static void Main(string[] args)
        {
            string isim = IsimAl();
            int yas = YasAl(isim);
            SonucYaz(isim, yas);
        }

        private static void SonucYaz(string isim , int yas )
        {
            // Buraya Kod Yazın
            if (yas >= 18 )
            {
                Console.WriteLine(isim +  " Kahveye hoş geldin");
            }
            else
            {
                int kalan = 18 - yas;
                Console.WriteLine(isim + " Kahveye girmek için " + kalan + " sene beklemelisin");
            }

            //.......
        }

        private static int YasAl(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
            Console.WriteLine("Kaç Yaşındasın ");
            return  Convert.ToInt32( (Console.ReadLine()));
        }

        private static string IsimAl()
        {
            Console.WriteLine("İsminiz Nedir");
            return Console.ReadLine();
        }
    }
}
