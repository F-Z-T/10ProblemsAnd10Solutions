using System;

namespace ödev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sınav1 = 0, sınav2 = 0, vize = 0, final = 0, proje = 0;
            Console.Write("kısa sınav1 notunu giriniz: ");
        Osınav1:
            sınav1 = Convert.ToDouble(Console.ReadLine());
            if (sınav1 < 0 || sınav1 > 100)
            {
                Console.Write("Notunuzu yanlış girdiniz.Tekrar deneyin.");
                goto Osınav1;
            }

            Console.Write("kısa sınav2 notunu giriniz:");
        Osınav2:
            sınav2 = Convert.ToDouble(Console.ReadLine());
            if (sınav2 < 0 || sınav2 > 100)
            {
                Console.Write("Notunuzu yanlış girdiniz.Tekrar deneyin.");
                goto Osınav2;

            }

            Console.Write("vize  notunu giriniz:");
        Ovize:
            vize = Convert.ToDouble(Console.ReadLine());
            if (vize < 0 || vize > 100)
            {
                Console.Write("Notunuzu yanlış girdiniz.Tekrar deneyin.");
                goto Ovize;

            }

            Console.Write("final  notunu giriniz:");
        Ofinal:
            final = Convert.ToDouble(Console.ReadLine());
            if (final < 0 || final > 100)
            {
                Console.Write("Notunuzu yanlış girdiniz.Tekrar deneyin.");
                goto Ofinal;

            }

            Console.Write("proje  notunu giriniz:");
        Oproje:
            proje = Convert.ToDouble(Console.ReadLine());
            if (proje < 0 || proje > 100)
            {
                Console.Write("Notunuzu yanlış girdiniz.Tekrar deneyin.");
                goto Oproje;

            }


            double Ort = ((sınav1 * 0.05) + (sınav2 * 0.05) + (vize * 0.30) + (final * 0.50) + (proje * 0.10));
            Console.WriteLine("Ortalamanız={0}", Ort);

            if (Ort > 0 && Ort < 29) Console.WriteLine("FF harf notu ile dersten kaldınız.");

            else if (Ort >= 30 && Ort <= 49) Console.WriteLine("FD harf notu ile dersten kaldınız.");

            else if (Ort >= 50 && Ort <= 54) Console.WriteLine("DD harf notu ile dersten kaldınız.");

            else if (Ort >= 55 && Ort <= 64) Console.WriteLine("DC harf notu ile dersten Şartlı geçtiniz.");

            else if (Ort >= 65 && Ort <= 74) Console.WriteLine("CC harf notu ile dersten başarıyla  geçtiniz.");

            else if (Ort >= 75 && Ort <= 79) Console.WriteLine("CB harf notu ile dersten başarıyla  geçtiniz.");

            else if (Ort >= 80 && Ort <= 44) Console.WriteLine("BB harf notu ile dersten başarıyla  geçtiniz.");

            else if (Ort >= 85 && Ort <= 89) Console.WriteLine("BA harf notu ile dersten başarıyla  geçtiniz.");

            else if (Ort >= 90 && Ort <= 100) Console.WriteLine("AA harf notu ile dersten başarıyla  geçtiniz.");

            Console.ReadKey();


        }
    }
}
