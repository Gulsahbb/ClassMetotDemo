using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MÜŞTERİ TAKİP LİSTESİ\n------------------------------");

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Ayşe";
            musteri1.MusteriSoyadi = "Xxxx";
            musteri1.MusteriYas = 25;
            musteri1.MusteriKartNumarasi = 345;
            musteri1.MusteriKatilimTarihi = 2009;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Kerem";
            musteri2.MusteriSoyadi = "Yyyy";
            musteri2.MusteriYas = 32;
            musteri2.MusteriKartNumarasi = 567;
            musteri2.MusteriKatilimTarihi = 2016;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Elif";
            musteri3.MusteriSoyadi = "Zzzz";
            musteri3.MusteriYas = 54;
            musteri3.MusteriKartNumarasi = 789;
            musteri3.MusteriKatilimTarihi = 2020;


             Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

              foreach (var musteri in musteriler)
            {
                Console.WriteLine( "Müşteri ID : " + musteri.MusteriId + "\nMüşteri Adı Soyadı: " + musteri.MusteriAdi
                    + " " + musteri.MusteriSoyadi + "\nMüşteri Yaşı : " + musteri.MusteriYas + "\nMüşteri Kart Numarası : " + musteri.MusteriKartNumarasi 
                    + "\nMüşteri Katılma Tarihi : " + musteri.MusteriKatilimTarihi);
                Console.WriteLine("------------------------------\n");

            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriSil(musteri3);
        }
    }
}
