using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Berk Anıl";
            musteri1.Soyadi = "Kızmaz";
            musteri1.Yas = 25;
            musteri1.email = "berkanil@example.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Fatma";
            musteri2.Soyadi = "Demir";
            musteri2.Yas = 25;
            musteri2.email = "fd@example.com";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Osman";
            musteri3.Soyadi = "Kaçar";
            musteri3.Yas = 22;
            musteri3.email = "osman@example.com";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};

            MusteriManager manager = new MusteriManager();
            manager.MusteriEkle(musteri1);
            manager.MusteriEkle(musteri3);
            manager.MusteriSil(musteri2);
            manager.MusteriListele(musteriler);
        }
    }
}
