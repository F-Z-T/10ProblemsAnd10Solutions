using System;

namespace ödev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int PM = 0;
            Console.Write("ÇEKMEK İSTEDİĞİNİZ PARA MİKTARINI GİRİNİZ: ");
            PM = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int  p100 = 0, p50 = 0, p20 = 0, p10 = 0;

            if (PM >= 100)
            {
                p100 = PM / 100;
                PM = PM % 100;
            }

            
           if (PM >= 50)
            {
                p50 = PM / 50;
                PM = PM % 50;
            }

            
           if (PM >= 20)
            {
                p20 = PM / 20;
                PM = PM % 20;
            }

           
            if (PM >= 10)
            {
                p10 = PM / 10;
                PM = PM % 10;
            }

           
            Console.WriteLine("100'lük Banknot Adedi   : " + p100);
            Console.WriteLine("50'lik Banknot Adedi    : " + p50);
            Console.WriteLine("20'lik Banknot Adedi    : " + p20);
            Console.WriteLine("10'luk Banknot Adedi    : " + p10);
            
            Console.ReadKey();
        }
    }
}
