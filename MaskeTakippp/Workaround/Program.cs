﻿using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
         {
            SelamVer("Erdem");
            SelamVer("Engin");
            SelamVer("Amir");
            SelamVer();

            int sonuc = Topla(6,58);


            string ogrenci1 = "Erdem";
            string ogrenci2 = "Engin";
            string ogrenci3 = "Amir";

       


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Erdem";
            ogrenciler[1] = "Engin";
            ogrenciler[2] = "Amir";

            ogrenciler =new string[4];

             ogrenciler[3] = "İlker";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1= new[] {"Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] {"Bursa", "Antalya", "Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "ERDEM";
            person1.LastName = "YILDIRIM";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 123;



            Person person2 = new Person();
            person2.FirstName = "Engin";

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);

            }

            List<string> yeniSehirler1 = new List<string> {"Ankara 1","İstanbul 1","İzmir 1" };

            yeniSehirler1.Add("Adana 1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }

     
        static void SelamVer(string isim= "isimsiz")
        {

            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=5,int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;

            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
    }
}
