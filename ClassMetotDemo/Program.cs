using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Galip";
            musteri1.Soyad = "Doğan";
            musteri1.DogumTarihi = new DateTime(1998, 1, 1);

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Ahmet";
            musteri2.DogumTarihi = new DateTime(1999, 1, 1);

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ali";
            musteri3.Soyad = "Ali";
            musteri3.DogumTarihi = new DateTime(2000, 1, 1);

            Musteri[] musteriler = new Musteri[]{ musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri1);
         

            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri2);
    

            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri3);

            musteriManager.MusteriListele(musteriler);

            


        }

        
    }
}
