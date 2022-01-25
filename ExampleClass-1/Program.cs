﻿using System;

namespace ExampleClass_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Halil";
            calisan1.Soyad = "Kakut";
            calisan1.No = 23243252;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ahmet";
            calisan2.Soyad = "yılmaz";
            calisan2.No = 43536774;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void  CalisanBilgileri()
        {
            Console.WriteLine("Çalışma Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }
    }
}
