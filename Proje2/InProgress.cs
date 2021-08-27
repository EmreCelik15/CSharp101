using System;
using System.Collections.Generic;
namespace Proje_2
{
    public class InProgress : IKartDal
    {
        List<Kart> _kart;
        public InProgress()
        {
            _kart = new List<Kart> { new Kart { Baslik = "6 kişiyle", Icerik = "Voleybol", Buyukluk = Kart.Buyuklukler.XS, Ozellikler = new TakımUyeleri { Ad = "Ceyhun", Soyad = "As", Id = 3 } } };
            foreach (var item in _kart)
            {
                System.Console.WriteLine("IN PROGRESS Line\n**************************\n\nBaşlık   :" + item.Baslik + "\n\nİçerik   :" + item.Icerik + "\n\nAtanan Kişi   :" + item.Ozellikler.Ad + " " + item.Ozellikler.Soyad + " " + item.Ozellikler.Id + "\n\nBüyüklük   :" + item.Buyukluk + "\n");

            }
        }
        public void Ekle(Kart kart)
        {

        }


        public void Sil(Kart kart)
        {

        }

        public void Tasi()
        {

        }


    }
}