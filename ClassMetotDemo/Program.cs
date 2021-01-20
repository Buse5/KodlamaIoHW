using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 0;
            musteri1.MusteriAd = "Buse";
            musteri1.MusteriSoyad = "YALÇIN";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 1;
            musteri2.MusteriAd = "Buğra";
            musteri2.MusteriSoyad = "YALÇIN";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("------------------------------------------");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            Console.WriteLine("------------------------------------------");

            musteriManager.MusteriSil(musteri1);
        }
    }
}
