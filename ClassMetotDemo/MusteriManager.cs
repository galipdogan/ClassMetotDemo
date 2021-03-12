using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Müşteri Eklendi: " + musteri.Ad);
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }
        }

        public void Sil(Musteri musteri)
        {
            
            Console.WriteLine("Müşteri Silindi: " + musteri.Ad);
        }


    }



}
