using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();
            SelamVer(" Musa");
            SelamVer(" Engin");
            SelamVer();
            
            int sonuc = Topla(3, 5);

            //Diziler /Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[] { ogrenci1, ogrenci2, ogrenci3 };

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            Person person1 = new Person();
            person1.FirstName ="MUSA";
            person1.LastName = "UYUMAZ";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 1;


            PttManager pttManager= new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();


            Console.WriteLine();
            
            
            
            
            
            static void SelamVer(string isim = " isimsiz")
            {
                Console.WriteLine("Merhaba" + isim);
            }
            static int Topla(int sayi1 = 5, int sayi2 = 10)
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplam : " + sonuc);
                return sonuc;
            
            }
        }

            private static void Degiskenler()
            {
                string mesaj = "Merhaba";
                double tutar = 100000;
                int sayi = 100;
                bool girisYapmisMi = false;

                string ad = "Musa";
                string soyad = "Uyumaz";
                int dogumYili = 1999;
                long tcNo = 12345678910;

                Console.WriteLine(mesaj);
            }
        }
        //pascal casing
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }

        }
    }

