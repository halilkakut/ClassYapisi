using System;

namespace ExampleClass_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            Console.WriteLine("******** Çalışan 1 **********");
            Calisan calisan1 = new Calisan("Halil","Kakut",2324566,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();
            // calisan1.Ad = "Halil";
            // calisan1.Soyad = "Kakut";
            // calisan1.No = 23243252;
            //calisan1.Departman = "İnsan Kaynakları";

            
            
            Console.WriteLine("********* Çalışan 2 Bilgileri **********");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ahmet";
            calisan2.Soyad = "yılmaz";
            calisan2.No = 43536774;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("******** Çalışan 3 Bilgileri **********");
            Calisan calisan3 = new Calisan("Şeref","Kakut");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){

        }

        public void  CalisanBilgileri()
        {
            Console.WriteLine("Çalışma Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }


    }
}
