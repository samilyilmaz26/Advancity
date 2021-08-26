using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
   
    public interface IInsan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cins { get; set; }
        public string BaslikAl(); 
    }
}
