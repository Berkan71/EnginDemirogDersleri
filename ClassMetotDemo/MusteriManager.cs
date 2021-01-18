using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("------ Musteri Ekleniyor ------");
            Console.WriteLine(musteri.Adi + " " +musteri.Soyadi + " isimli Müşteri Eklendi..");
            Console.WriteLine("----------------------------------------------\n");
        }

        public void MusteriSil(Musteri musteri) 
        {
            Console.WriteLine("------ Musteri Siliniyor ------");
            Console.WriteLine(musteri.Id +" Numaralı " +musteri.Adi + " " + musteri.Soyadi + " isimli Müşteri Silindi..");
            Console.WriteLine("----------------------------------------------\n");
        }

        public void MusteriListele(Musteri[] musteriler) 
        {
            Console.WriteLine("------ Musteriler Listeleniyor ------\n");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Adı : "+ musteri.Adi);
                Console.WriteLine("Musteri Soyadı : "+musteri.Soyadi);
                Console.WriteLine("Musteri Yasi : "+musteri.Yas);
                Console.WriteLine("Musteri email adresi : "+musteri.email);
                Console.WriteLine("----------------------------------------\n");

            }
        }
    }

    


}
