using System;

namespace ödev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar1, kenar2, kenar3;

            Console.WriteLine("kenar1 uzunluğunu giriniz");
            kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kenar2 uzunluğunu giriniz");
            kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kenar3 uzunluğunu giriniz");
            kenar3 = Convert.ToInt32(Console.ReadLine());

            if (((kenar1 + kenar2) > kenar3) && (Math.Abs(kenar1 - kenar2) < kenar3) && ((kenar1 + kenar3) > kenar2) && (Math.Abs(kenar1 - kenar3) < kenar2) && ((kenar3 + kenar2) > kenar1) && (Math.Abs(kenar3 - kenar1) < kenar1))
            {
                Console.WriteLine("{0}, {1} ve {2} kenarları ile üçgen oluşturulabilir.", kenar1, kenar2, kenar3);

            }
            else 
            {
                Console.WriteLine("{0}, {1} ve {2} kenarları ile üçgen oluşturulamaz.", kenar1, kenar2, kenar3);
            }
            Console.ReadKey();

        }
    }
}
