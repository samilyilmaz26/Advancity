using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
    // Buraya Kodunuzu Yazın
    public interface IAdres
    {
        public string  Cadde { get; set; }
        public string  Sokak { get; set; }
        public string  KapiNo { get; set; }
        public string  Ilce { get; set; }
        public string  Il  { get; set; }
        public List<string> AdresAl();    

    }
}
