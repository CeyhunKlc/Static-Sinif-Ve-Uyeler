using System;

namespace static_sinif_ve_uyeler
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.Calisansayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.Calisansayisi);
            Calisan calisan1 = new Calisan("Deniz","Arda","IK");
            Calisan calisan2 = new Calisan("Ceyhun","Kılıç","IK");

            Console.WriteLine("Çalışan Sayısı:{0}",Calisan.Calisansayisi);

          Console.WriteLine("Toplama İşlemi Sonucu: {0}",Islemler.Topla(100,200));
          Console.WriteLine("Çıkarma İşlemi Sonucu: {0}",Islemler.Çıkar(400,50));  

        }
    }

    class Calisan
    { 
        private static int calisansayisi;

        public static int Calisansayisi { get => calisansayisi; set => calisansayisi = value; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){ 
            calisansayisi=0;
        }

        public Calisan(string isim, string soyisim, string departman)
        { 
            this.Isim= isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisansayisi ++;
        }
    }

    static class Islemler
    { 
        public static long Topla(int sayi1, int sayi2)
        { 
            return sayi1 + sayi2;
        }

        public static long Çıkar(int sayi1, int sayi2)
        { 
            return sayi1 - sayi2;
        }
    }
}      
