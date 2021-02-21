using System;

namespace ödev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int F, Z, T;
            double disk, x1, x2, kok;

            Console.WriteLine("F Degerini Giriniz: ");
            F = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Z Degerini Giriniz: ");
            Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("T Degerini Giriniz: ");
            T = Convert.ToInt32(Console.ReadLine());

            disk = Z * 2 - (4 * F * T);



            if (disk > 0)
            {
                x1 = (-Z + Math.Sqrt(disk)) / (2 * F);
                x2 = (-Z - Math.Sqrt(disk)) / (2 * F);
                Console.WriteLine("X1=" + x1 + " " + "X2=" + x2);
                Console.Read();
            }


            else if (disk == 0)
            {
                Console.WriteLine("çakışık iki kökü vardır.\n");
                Console.WriteLine("x1=x2=" + -Z / 2 * F);
                Console.Read();
            }


            else if (disk < 0)
            {
                Console.WriteLine("kök yoktur.");
                Console.Read();
            }
        }
    }
}
