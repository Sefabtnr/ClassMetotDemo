using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri musteri )
        {
            Console.WriteLine("müşteri eklendi=" + musteri.AdSoyad);
            
        }
           public void listele(string AdSoyad, string Aciklama)
        {

            Console.WriteLine("müşteri listelendi = " + AdSoyad );
            Console.WriteLine("müşteri listelendi = " + Aciklama);
        }
        public void sil (Musteri musteri)
        {
            Console.WriteLine("müşteriyi silindi = " + musteri.AdSoyad);

        }
    }
}
