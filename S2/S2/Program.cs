using System;

namespace S2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir Sayı Giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            
            for (int i = 1; i <= sayi / 2; i++)
            {

                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            Console.WriteLine("");
            
            if (sayi == toplam)
            {
                Console.WriteLine(sayi + " Sayısı  Mükemmel Sayıdır");
            }
            else
            {
                Console.WriteLine(sayi + " Sayısı  Mükemmel Sayı Değildir");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
