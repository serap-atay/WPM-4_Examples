using System;

namespace KDVHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double kdv = 0, fiyat = 0,yenifiyat=0;
            Console.WriteLine("Fiyat değerini giriniz.");
            try
            {

                fiyat = int.Parse(Console.ReadLine()); 
            }
            catch (Exception)
            {
                Console.WriteLine("Fiyat tutarını doğru giriniz!");
            }
            kdv = fiyat * 0.18;
            yenifiyat = fiyat + kdv;
            Console.WriteLine($"KDVli fiyat: {yenifiyat}");
        }
    }
}
