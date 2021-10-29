using System;

namespace Girilen10sayınınnToplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir sayi giriniz: ");
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Sadece sayi giriniz!");
                }
                toplam += sayi;
            }
            Console.WriteLine($"Toplam : {toplam}");
        }
    }
}
