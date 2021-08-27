using System;
using System.Collections.Generic;
namespace Proje_2
{
    public interface IKartDal
    {
        void Ekle(Kart kart);
        void Sil(Kart kart);
        void Tasi();

    }
}