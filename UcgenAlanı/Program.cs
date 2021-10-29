using System;

namespace UcgenAlanı
{
    class Program
    {
        static void Main(string[] args)
        {
            int taban=0, h=0;
            do
            {
                try
                {
                    Console.WriteLine("Üçgenin yüksekliğini giriniz: ");
                    taban = int.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin taban uzunluğunu giriniz: ");
                    h = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen bir sayi giriniz!");
                }
                int sonuc = (h * taban) / 2;
                Console.WriteLine($" sonuc - {sonuc}");
                Console.WriteLine("oyuna devam etme için E ye basınız: ");
            } while (Console.ReadLine().ToLower()=="e".ToLower());
        }
    }
}
