using System;
using System.Collections.Generic;
namespace Proje_2

{
    public class Kart:IKart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public TakımUyeleri Ozellikler;
        public enum Buyuklukler { XS = 1, S = 2, M = 3, L = 4, XL = 5 };
        public Buyuklukler Buyukluk{get;set;}
    }

    
}