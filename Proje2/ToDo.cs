using System;
using System.Collections.Generic;
namespace Proje_2
{
    public class ToDo : IKartDal
    {
        private string _baslik;
        private string _icerik;
        private enum _buyukluk{};
        private TakımUyeleri _kisi;
        List<Kart> _kart;

        public ToDo()
        {
            _kart = new List<Kart> { new Kart { Baslik = "11 kişiyle", Icerik = "Baseketbol", Buyukluk = Kart.Buyuklukler.XS, Ozellikler = new TakımUyeleri { Ad = "Ali", Soyad = "Yılmaz", Id = 2 } } };
            foreach (var item in _kart)
            {
                System.Console.WriteLine("TODO Line\n**************************\n\nBaşlık   :" + item.Baslik + "\n\nİçerik   :" + item.Icerik + "\n\nAtanan Kişi   :" + item.Ozellikler.Ad + " " + item.Ozellikler.Soyad + " " + item.Ozellikler.Id + " " + "\n\nBüyüklük   :" + item.Buyukluk + "\n");

            }
        }
        public void Ekle(Kart kart)
        {
            System.Console.WriteLine("Lütfen başlık giriniz.");
            _baslik=Console.ReadLine();
            _baslik=kart.Baslik;
            
            foreach (var item in _kart)
            {
                System.Console.WriteLine(item.Baslik);
            }

        }

        public void Sil(Kart kart)
        {

        }

        public void Tasi()
        {

        }
    }
}