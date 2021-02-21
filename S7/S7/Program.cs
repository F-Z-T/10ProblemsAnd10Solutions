using System;

namespace S7
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecici;
            int buyuk, kucuk;
            double toplam = 0, ortalama = 0;
            int[] sayilar = new int[20];
            Random r = new Random();
            for (int a = 0; a < sayilar.Length; a++)
            {
                sayilar[a] = r.Next(1, 300);
            }

            Console.WriteLine("Oluşturulan Dizin :");
            foreach (int sayi in sayilar)
            {
                Console.Write("{0} ", sayi);
            }
            Console.WriteLine();

            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int x = i + 1; x < sayilar.Length; x++)
                {
                    if (sayilar[i] < sayilar[x])
                    {
                        gecici = sayilar[x];
                        sayilar[x] = sayilar[i];
                        sayilar[i] = gecici;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Dizinin büyükten küçüğe sıralanmış hali : ");
            foreach (int sayi in sayilar)
            {
                Console.Write("{0} ", sayi);
            }
            buyuk = sayilar[0];
            kucuk = sayilar[0];
            foreach (int sayi in sayilar)
            {
                if (sayi > buyuk)
                {
                    buyuk = sayi;
                }
                if (sayi < kucuk)
                {
                    kucuk = sayi;
                }

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Dizideki En Büyük Sayi : {0}", buyuk);
            Console.WriteLine("Dizideki En küçük sayi : {0}", kucuk);


            for (int i = 0; i < sayilar.Length; ++i)
            {
                toplam += sayilar[i];
            }
            ortalama = toplam / (sayilar.Length);

            Console.WriteLine("");
            Console.WriteLine("Dizinin Ortalaması : " + ortalama);

        }
    }
}
