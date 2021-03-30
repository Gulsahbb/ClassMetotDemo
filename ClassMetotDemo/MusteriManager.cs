using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi!" + "\nMüşteri ID : " + musteri.MusteriId + "\nMüşteri Adı Soyadı: " + musteri.MusteriAdi
                      + " " + musteri.MusteriSoyadi + "\nMüşteri Yaşı : " + musteri.MusteriYas + "\nMüşteri Kart Numarası : " + musteri.MusteriKartNumarasi
                      + "\nMüşteri Katılma Tarihi : " + musteri.MusteriKatilimTarihi);
            Console.WriteLine("------------------------------------------");
        }
        public void MusteriListele(Musteri musteri)
        {
                Console.WriteLine("Müşteriler listelendi!" + "\nMüşteri ID : " + musteri.MusteriId + "\nMüşteri Adı Soyadı: " + musteri.MusteriAdi
                         + " " + musteri.MusteriSoyadi + "\nMüşteri Yaşı : " + musteri.MusteriYas + "\nMüşteri Kart Numarası : " + musteri.MusteriKartNumarasi
                         + "\nMüşteri Katılma Tarihi : " + musteri.MusteriKatilimTarihi);
                Console.WriteLine("------------------------------------------");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silinen müşteri ve bilgileri" + "\nMüşteri ID : " + musteri.MusteriId + "\nMüşteri Adı Soyadı: " + musteri.MusteriAdi
                     + " " + musteri.MusteriSoyadi + "\nMüşteri Yaşı : " + musteri.MusteriYas + "\nMüşteri Kart Numarası : " + musteri.MusteriKartNumarasi
                     + "\nMüşteri Katılma Tarihi : " + musteri.MusteriKatilimTarihi);
            Console.WriteLine("------------------------------------------");
        }


    }
}
