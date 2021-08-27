using System;

namespace Encapsulation_and_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Isim = "Emre",
                Soyİsim = "Celik",
                OgrenciNo = 19,
                Sinif = 0
            };
            ogrenci.OgrenciBilgileri();
            
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyİsim;
        private int ogrenciNo;
        private int sinif;



        public string Isim { get => isim; set => isim = value; }
        public string Soyİsim { get => soyİsim; set => soyİsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif; set {
            if (value<1)
            {
                Console.WriteLine("Sinif 1'den küçük olamaz");
                sinif=1;
                
            }
            else
            {
                sinif=value;
            }
        } }
        public Ogrenci(string isim, string soyİsim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyİsim = soyİsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        {
        }
        public void OgrenciBilgileri(){
            Console.WriteLine(Isim);
            Console.WriteLine(Soyİsim);
            Console.WriteLine(OgrenciNo);
            Console.WriteLine(Sinif);
        }
    }
}