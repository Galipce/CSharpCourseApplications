using Bussiness.Concrete;
using Entities.Concrete;
using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler();

            //Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Galip");
            SelamVer();

            int sonuc = Topla(3, 5);

            int sonuc2 = Topla();
            
            int sonuc3 = Topla(50);

            //Diziler / Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Galip";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Ahmet";

            ogrenciler = new string[4];
            ogrenciler[3] = "Kerem";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            //referans olarak atanır ve sonucta sehirler1 in 0ıncı elemanı değişir. Artık sehirler2 de sehirler1 datalarını tutmakta.
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName= "Galip";
            person1.LastName = "Badem";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 11111111112;

            Person person2 = new Person();
            person2.FirstName = "Ahmet";

            //string referans tiptir ama değer tip olarak çalışır.

            //Foreach ile biz dizileri yazıyoruz
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add("İzmir1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SelamVer(string isim = "NoName")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
    }

    //    private static void Değişkenler()
    //    {
    //        string mesaj = "Selam";
    //        double tutar = 100000; // db den gelir
    //        int sayi = 100;
    //        bool girisYapmisMi = false;


    //        string ad = "Galip";
    //        string soyad = "Badem";
    //        int dogumYili = 2000;
    //        long tcNo = 12345678910;

    //        Console.WriteLine(mesaj);
    //        Console.WriteLine(tutar * 1.18);
    //        Console.WriteLine(mesaj);
    //    }
    //}

    //public class Vatandas
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set;}
    //    public int DogumYili { get; set; }
    //    public long TcNo { get; set; }

    //    //string ad = "Galip";
    //    //string soyad = "Badem";
    //    //int dogumYili = 2000;
    //    //long tcNo = 12345678910;
    //}
}