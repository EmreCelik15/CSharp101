using System;
using System.Collections.Generic;
namespace Proje_2
{
    public class Done : IKartDal
    {

        List<Kart> _kart;

        public Done()
        {
            _kart = new List<Kart> { new Kart { Baslik = "5 kişiyle", Icerik = "Baseketbol", Buyukluk = Kart.Buyuklukler.XS, Ozellikler = new TakımUyeleri { Ad = "Emre", Soyad = "Çelik", Id = 1 } } };
            foreach (var item in _kart)
            {
                System.Console.WriteLine("DONE Line\n**************************\n\nBaşlık   :" + item.Baslik + "\n\nİçerik   :" + item.Icerik + "\n\nAtanan Kişi   :" + item.Ozellikler.Ad + " " + item.Ozellikler.Soyad + " " + item.Ozellikler.Id + "\n\nBüyüklük   :" + item.Buyukluk + "\n");

            }
        }
        public void Ekle(Kart kart)
        {
            throw new NotImplementedException();
        }

        public void Sil(Kart kart)
        {
            throw new NotImplementedException();
        }

        public void Tasi()
        {
            throw new NotImplementedException();
        }

    }
}