using System;

namespace _3ve5BölünebilenSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            do
            {
                Console.WriteLine("Bir sayi giriniz:");
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sadece sayi girebilirsiniz.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen bir sayi giriniz.");
                }
                if (sayi % 3 == 0 && sayi % 5 == 0)
                {
                    Console.WriteLine($"{sayi} sayisi 3 ve 5 bölünebilir.");
                }
                else
                {
                    Console.WriteLine($"{sayi} sayisi 3 veya 5 e bölünemez.");
                }
                Console.WriteLine("Oyuna devam etmek için E ye basınız.");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);
            }
        }
    }

