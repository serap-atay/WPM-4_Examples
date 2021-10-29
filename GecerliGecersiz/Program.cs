using System;

namespace GecerliGecersiz
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("0-100 arasında bir sayi giriniz:");
                int sayi = 0;
                do
                {
                    try
                    {
                        sayi = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Lütfen bir sayi giriniz!");
                    }
                } while (true);
                if (sayi >= 0 && sayi <= 100)
                {
                    Console.WriteLine($"{sayi} sayisi Geçerlidir.");
                }
                else
                {
                    Console.WriteLine($"{sayi} sayisi Geçersizdir.");
                }
                Console.WriteLine("Oyuna Devam etmek için Eye basınız:");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key!=ConsoleKey.E)
                {
                    break;
                }
            } while (true);
        }
    }
}