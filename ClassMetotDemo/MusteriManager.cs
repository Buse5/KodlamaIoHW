using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public string[] musteriler = new string[] { };

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " ID'li " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " isimli kullanıcı kaydedilmiştir.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " ID'li " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " isimli kullanıcı silinmiştir.");

        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " ID'li ");
            Console.WriteLine(musteri.MusteriAd + " isimli");
            Console.WriteLine(musteri.MusteriSoyad + " soyisimli");
        }
    }
}
