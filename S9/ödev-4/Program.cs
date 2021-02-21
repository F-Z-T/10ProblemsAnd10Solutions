using System;

namespace ödev_4
{
    class Program
    {
        static void Main(string[] args)
        {

            double sec, alan, hacim, cevre;
            int a, b, r, h;
            Console.WriteLine("1-küre alanı ve hacmi");
            Console.WriteLine("2-daire alanı ve cevre");
            Console.WriteLine("3-silindir alanı ve hacmi");
            Console.WriteLine("4-dikdörtgen alanı ve hacmi");
            Console.WriteLine("5-küp alanı ve hacmi");
            Console.WriteLine("---------------------");
            Console.Write("SEÇİMİNİZ:");
            sec = Convert.ToDouble(Console.ReadLine());

            if (sec == 1)
            {
                Console.WriteLine("küre yarıçapı ");
                r = Convert.ToInt32(Console.ReadLine());

                alan = Convert.ToInt32(4 * Math.PI * Math.Pow(r, 2));
                hacim = Convert.ToInt32((4 * Math.PI * Math.Pow(r, 3)) / 3);

                Console.WriteLine("Alan = " + alan);
                Console.WriteLine("Hacim = " + hacim);
                Console.ReadKey();
            }

            else if (sec == 2)
            {
                Console.WriteLine("daire yarıçapı ");
                r = Convert.ToInt32(Console.ReadLine());

                alan = Convert.ToInt32(Math.PI * Math.Pow(r, 2));
                cevre = Convert.ToInt32((2 * Math.PI * Math.Pow(r, 1)));

                Console.WriteLine("Alan = " + alan);
                Console.WriteLine("Hacim = " + cevre);
                Console.ReadKey();
            }

            else if (sec == 3)
            {
                Console.Write("Yarıçapı Girin  ");
                r = Convert.ToInt32(Console.ReadLine());
                Console.Write("Yüksekliği Girin : ");
                h = Convert.ToInt32(Console.ReadLine());
                alan = Convert.ToInt32(2 * 3.14 * (r + h));
                hacim = Convert.ToInt32(3.14 * r * r * h);


                Console.WriteLine("Alan = " + alan);
                Console.WriteLine("Hacim = " + hacim);
                Console.ReadKey();

            }

            else if (sec == 4)
            {

                Console.WriteLine("a kenarını girin : ");
                Console.WriteLine("b kenarını girin : ");
                Console.WriteLine("h kenarını girin : ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                h = Convert.ToInt32(Console.ReadLine());
                alan = Convert.ToInt32((a * b + b * h + a * h) * (a * b + b * h + a * h) * 2);
                hacim = Convert.ToInt32(a * b * h);
                Console.WriteLine("Alan = " + alan);
                Console.WriteLine("Hacim = " + hacim);
                Console.ReadKey();
            }

            else if (sec == 5)
            {
                Console.Write("küpün kenar uzunluğunu  girin : ");
                a = Convert.ToInt32(Console.ReadLine());
                alan = Convert.ToInt32(6 * a * a);
                hacim = Convert.ToInt32(a * a * a);
                Console.WriteLine("Alan = " + alan);
                Console.WriteLine("Hacim = " + hacim);
                Console.ReadKey();
            }






        }
    }
}
