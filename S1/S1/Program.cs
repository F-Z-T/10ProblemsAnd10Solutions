using System;

namespace S1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            int a, enB, b, sayi;
            Console.WriteLine("sayı giriniz");
    
            a = Convert.ToInt32(Console.ReadLine());
            enB = 0;

            while (a != 0)
            {
                b = a - a / 10 * 10;
                if (enB < b)
                {
                    enB = b;
                }
                a = a / 10;

            }

            Console.WriteLine("En büyük değer : " + enB);

        }
    }
}




