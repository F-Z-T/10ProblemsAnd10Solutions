using System;

namespace S6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0, ciftToplam = 0, sayac = 0, b2a = 0, b3a = 0, b4a = 0, b5a = 0, b6a = 0, b7a = 0, b8a = 0, b9a = 0, b2468a = 0, b37a = 0;
            int bol2 = 0, bol3 = 0, bol4 = 0, bol5 = 0, bol6 = 0, bol7 = 0, bol8 = 0, bol9 = 0, bol2468 = 0, bol37 = 0;


            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam = ciftToplam + i;
                    sayac++;
                }
                else
                {
                    tekToplam = tekToplam + i;
                }

                if (i % 2 == 0)
                {
                    bol2 = bol2 + i;
                    b2a++;
                }


                if (i % 3 == 0)
                {
                    bol3 = bol3 + i;
                    b3a++;
                }
                if (i % 4 == 0)
                {
                    bol4 = bol4 + i;
                    b4a++;
                }
                if (i % 5 == 0)
                {
                    bol5 = bol5 + i;
                    b5a++;
                }
                if (i % 6 == 0)
                {
                    bol6 = bol6 + i;
                    b6a++;
                }
                if (i % 7 == 0)
                {
                    bol7 = bol7 + i;
                    b7a++;
                }
                if (i % 8 == 0)
                {
                    bol8 = bol8 + i;
                    b8a++;
                }
                if (i % 9 == 0)
                {
                    bol9 = bol9 + i;
                    b9a++;
                }

                if (i % 2 == 0 && i % 4 == 0 && i % 6 == 0 && i % 8 == 0)
                {
                    bol2468 = bol2468 + i;
                    b2468a++;
                }
                if (i % 3 == 0 && i % 7 == 0)
                {
                    bol37 = bol37 + i;
                    b37a++;
                }

            }

            Console.WriteLine("0-100 arası Çift Sayıların Toplamı : " + ciftToplam);
            Console.WriteLine("0-100 arası Çift Sayıların adedi : " + sayac);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası Tek Sayıların Toplamı : " + tekToplam);
            Console.WriteLine("0-100 arası Tek Sayıların adedi : " + sayac);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 2'ye bölünen Sayıların Toplamı : " + bol2);
            Console.WriteLine("0-100 arası 2'ye bölünen  Sayıların adedi : " + b2a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 3'e bölünen Sayıların Toplamı : " + bol3);
            Console.WriteLine("0-100 arası 3'e bölünen  Sayıların adedi : " + b3a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 4'e bölünen Sayıların Toplamı : " + bol4);
            Console.WriteLine("0-100 arası 4'e bölünen  Sayıların adedi : " + b4a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 5'e bölünen Sayıların Toplamı : " + bol5);
            Console.WriteLine("0-100 arası 5'e bölünen  Sayıların adedi : " + b5a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 6'ya bölünen Sayıların Toplamı : " + bol6);
            Console.WriteLine("0-100 arası 6'ya bölünen  Sayıların adedi : " + b6a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 7'ye bölünen Sayıların Toplamı : " + bol7);
            Console.WriteLine("0-100 arası 7'ye bölünen  Sayıların adedi : " + b7a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 8'e bölünen Sayıların Toplamı : " + bol8);
            Console.WriteLine("0-100 arası 8'e bölünen  Sayıların adedi : " + b8a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 9'a bölünen Sayıların Toplamı : " + bol9);
            Console.WriteLine("0-100 arası 9'a bölünen  Sayıların adedi : " + b9a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 2,4,6 ve 8 ile tam  bölünen Sayıların Toplamı : " + bol2468);
            Console.WriteLine("0-100 arası 2, 4, 6 ve 8 ile tam  bölünen Sayıların adedi : " + b2468a);
            Console.WriteLine("");
            Console.WriteLine("0-100 arası 3 ve 7 ile tam  bölünen Sayıların Toplamı : " + bol37);
            Console.WriteLine("0-100 arası 3 ve 7 ile tam  bölünen Sayıların adedi : " + b37a);

        }
    }
}
