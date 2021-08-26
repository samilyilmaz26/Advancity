using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
     
    public class Temel : IInsan, IAdres
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cins { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public string KapiNo { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }

        public List<string> AdresAl()
        {
            List<string> adres = new List<string>();
            adres.Add(BaslikAl());
            adres.Add(Cadde);
            adres.Add(Sokak);
            adres.Add(KapiNo.ToString());
            adres.Add($"{Ilce}-{Il}");
            return adres;

        }

        public virtual string BaslikAl()
        {
            if (Cins == "E")
            {
                return $" Sn Bay {Ad} {Soyad} ";
            }
            else
            {
                return $" Sn Bayan {Ad} {Soyad} ";
            }
        }
    }
}
