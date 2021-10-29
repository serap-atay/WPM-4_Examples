using System;

namespace _3SayıdanBüyükOlanıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            try
            {
                Console.WriteLine("A sayisiniz giriniz: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("B sayisiniz giriniz: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("C sayisiniz giriniz: ");
                c = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bir sayi giriniz:");
            }
            if (a>b && a>c)
            {
                Console.WriteLine($"En büyük sayi: {a}");
            }
            else if (b>c)
            {
                Console.WriteLine($"En büyük sayi: {b}");
            }
            else
            {
                Console.WriteLine($"En büyük sayi: {c}");
            }
        }
    }
}
