using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Hasan Sefa Bütüner";
            musteri1.Aciklama = "borcu yok...";

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Osman Bütüner";
            musteri2.Aciklama = "1000tl borcu var..";

            Musteri musteri3 = new Musteri();
            musteri3.AdSoyad = "Recep Bütüner";
            musteri3.Aciklama = "2000tl borcu var..";

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in Musteriler)

            {
               
                Console.WriteLine(musteri.AdSoyad);
                Console.WriteLine(musteri.Aciklama);
                
            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(musteri1);
            musteriManager.ekle(musteri2);
            musteriManager.ekle(musteri3);

            musteriManager.listele("Hasan Sefa Bütüner", "borcu yok");
            musteriManager.listele("Osman Bütüner", "1000 tl borcu var");
            musteriManager.listele("Recep Bütüner", "2000 tl borcu var");

            musteriManager.sil(musteri1);
            musteriManager.sil(musteri2);
            musteriManager.sil(musteri3);

        }
    }
}
