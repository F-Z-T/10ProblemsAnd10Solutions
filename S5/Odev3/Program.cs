using System;
using System.Collections;

namespace Odev3
{
    class Program
    {
        static void GiseleriEkle(ArrayList giseler)
        {
            String[] giseAdi = { "Abant", "Düzce", "Batı Hereke", "Batı İzmit", "Babaeski", "Ankara", "Gerede", "Kurtköy", "Kaynaşlı", "Mahmutbey" };
            foreach(string gise in giseAdi)
            {
                giseler.Add(gise);
            }
        }
       static void GiseleriYazdir(ArrayList giseler)
        {
            int sayac = 0;
            foreach (string gise in giseler)
            {
                sayac++;
                Console.WriteLine(sayac + "-" + gise);
            }
        }
        static int GirisYapilanGise(ArrayList giseler,string aranan)
        {
            int giseIndex=0, sayac=0;
            foreach(string gise in giseler)
            {
                sayac++;
                if(gise.ToLower()==aranan.ToLower())
                {
                    giseIndex = sayac;
                }
            }

            return giseIndex;
        }

        static int CikisYapilanGise(ArrayList giseler, string aranan)
        {
            int giseIndex = 0, sayac = 0;
            foreach (string gise in giseler)
            {
                sayac++;
                if (gise.ToLower() == aranan.ToLower())
                {
                    giseIndex = sayac;
                }
            }

            return giseIndex;
        }

        static int UcretHesapla(int girisIndex, int cikisIndex, bool kopruDurumu)
        {
            int ucret = (Math.Abs(girisIndex-cikisIndex)*15);
            if(kopruDurumu==true)
            {
                ucret = ucret + 8;
            }
            return ucret;
        }
        static void Main(string[] args)
        {
            string tercih = "";
            bool kopruDurumu=false;
            string girisGisesi="";
            string cikisGisesi = "";
            int giseGirisIndex=0;
            int giseCikisIndex=0;
            bool dongu1 = true;
            bool dongu2 = true;
            bool dongu3 = true;
            ArrayList  giseler = new ArrayList();
            GiseleriEkle(giseler);

        Console.WriteLine("GEÇİŞ ÜCRETİ HESAPLAMA");

            while (dongu1)
            {
                Console.WriteLine("**********************************");
                GiseleriYazdir(giseler);
                Console.Write("Giriş yaptığınız gişe adı : ");
                girisGisesi = Console.ReadLine();
                giseGirisIndex = GirisYapilanGise(giseler, girisGisesi );
                if (giseGirisIndex != 0)
                {
                    dongu1 = false;
                }
                else
                {
                    Console.WriteLine("Yazdığınız gişe dizide bulunamadı!");
                }
            }
            while (dongu2)
            {
                Console.WriteLine("**********************************");
                GiseleriYazdir(giseler);
                Console.Write("Çıkış yaptığınız gişe adı : ");
                cikisGisesi = Console.ReadLine();
                giseCikisIndex=CikisYapilanGise(giseler, cikisGisesi);
                Console.WriteLine("**********************************");
                if(giseCikisIndex != 0)
                {
                    dongu2 = false;
                }
                else
                {
                    Console.WriteLine("Yazdığınız gişe dizide bulunamadı!");
                }
            }
            while (dongu3)
            {
                Console.Write("Köprü Kullandınız mı ? E/H : ");
                tercih = Console.ReadLine();
                if(tercih.ToUpper()=="E")
                {
                    dongu3 = false;
                    kopruDurumu = true;
                }
                else if(tercih.ToUpper() == "H")
                {
                    dongu3 = false;
                    kopruDurumu = false;
                }
                else
                {
                    Console.WriteLine("Lütfen verilen seçeneklerden birisini seçiniz!");
                }

                Console.WriteLine("**********************************");
            }

            Console.WriteLine("Giriş Yapılan Gişe: "+girisGisesi);
            Console.WriteLine("Çıkış Yapılan Gişe: "+cikisGisesi);
            Console.WriteLine("Toplam Ücret: "+UcretHesapla(giseGirisIndex,giseCikisIndex,kopruDurumu).ToString());

            Console.ReadKey();
            
        }      

    }
}

