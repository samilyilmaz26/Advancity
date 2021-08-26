using System;

namespace Kalitim
{
    class Program
    {
        // Programın amamcı Kalıtım almayı ve Polymorphizm  öğrenmiş olmak
        // Iki Adet Interface (IAdres, IInsan )den bir temel nesne yaratmek
        // Temel Nesneden ise İki adet nesne yaratmak (Egitmen ve Ogrenci)

        // Ogrenci nesnesinde Adres Yazarken

        //  Sn Bay  Ali Yılmaz Bu bilgi Baslık Yaz Metotdan Gelecek
        // Aşağıdaki Bilgiler AdresAl metotdan gelecek
        //  Atatürk Cad 
        // Yaprak Sokak
        // NO : 7
        // Kadıköy - Istanbul 

        // Egitmen  nesnesinde Adres Yazarken
        //  Sn Doçent Doktor  Murat  Yılmaz Bu bilgi Baslık Yaz Metotdan Gelecek
        // Aşağıdaki Bilgiler AdresAl metotdan gelecek
        //  Atatürk Cad 
        // Yaprak Sokak
        // NO : 7
        // Kadıköy - Istanbul 

        // Yukardaki Bilgiler Temel class da olacak
        // Ogrenci Class da fazladan Bölüm
        // Egitmen  Class da Fazladan Unvan Olacak
        static void Main(string[] args)
        {
             OgrenciAdresiYaz();
            EgitmenAdresAl();

        }

        private static void EgitmenAdresAl()
        {
            // Buraya Kod Yazın
            Egitmen egitmen = new Egitmen();
            egitmen.Id = Convert.ToInt32(Cevir("Id Giriniz"));
            egitmen.Ad = Cevir("Ad Giriniz");
            egitmen.Soyad = Cevir("Soyadı  Giriniz");
            egitmen.Cadde = Cevir("Cadde Adı  Giriniz");
            egitmen.Cins = Cevir("Cinsiyet Giriniz  E erkek  K Kadın ");
            egitmen.Il = Cevir("Il Adı Giriniz");
            egitmen.Ilce = Cevir("Ilçe Adı Giriniz");
            egitmen.KapiNo = Cevir("Kapı No  Adı Giriniz");
            egitmen.Sokak = Cevir("Sokak Adı Giriniz");
            egitmen.Unvan = Cevir("Unvan  Adı Giriniz");
         
            var alist = egitmen.AdresAl();
            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }
        }

        private static string Cevir(string txt)
        {
            Console.WriteLine(txt);
            return Console.ReadLine();
        }

        private static void OgrenciAdresiYaz()
        {
            Ogrenci  ogr = new Ogrenci();
            ogr.Id = Convert.ToInt32(Cevir("Id Giriniz"));
            ogr.Ad = Cevir("Ad Giriniz");
            ogr.Soyad = Cevir("Soyadı  Giriniz");
            ogr.Cadde = Cevir("Cadde Adı  Giriniz");
            ogr.Cins = Cevir("Cinsiyet Giriniz  E erkek  K Kadın ");
            ogr.Il = Cevir("Il Adı Giriniz");
            ogr.Ilce = Cevir("Ilçe Adı Giriniz");
            ogr.KapiNo = Cevir("Kapı No  Adı Giriniz");
            ogr.Sokak = Cevir("Sokak Adı Giriniz");
            

            var alist = ogr.AdresAl();
            foreach (var item in alist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
