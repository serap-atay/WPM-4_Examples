using System;

namespace KatıSıvıGazOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int derece = 0;
                Console.WriteLine("Suyun sıcaklık derecesini giriniz:");
                try
                {
                    derece = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen bir sayi giriniz!");
                }
                if (derece <= 0)
                {
                    Console.WriteLine($"Madde hali: KATI");
                }
                else if (derece > 0 && derece <= 100)
                {
                    Console.WriteLine($"Madde Hali: SIVI");
                }
                else
                {
                    Console.WriteLine($"Madde Hali: GAZ");
                }
                Console.WriteLine("Oyuna Devam Etmek için E basınız:");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key==ConsoleKey.H)
                {
                    break;
                }
            } while (true);
        }
    }
}
