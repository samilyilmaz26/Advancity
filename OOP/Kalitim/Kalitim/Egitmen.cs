using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
    // Buraya Kodunuzu Yazın
    public class Egitmen: Temel
    {
        public string  Unvan { get; set; }
        public override string BaslikAl()
        {
            return $" Sn  {Unvan} {Ad} {Soyad}";
        }
    }
}
