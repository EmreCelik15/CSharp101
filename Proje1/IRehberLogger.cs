using System;
using System.Collections.Generic;

namespace Proje_1
{
    public interface IRehberLogger{ 

    void Ekle(Kisi kisi);
    void Sil(Kisi kisi);
    void Güncelle(Kisi kisi);
    List<Kisi> Listele(); 
    void Bul(Kisi kisi);
     
    }
}