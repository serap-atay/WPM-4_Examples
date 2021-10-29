using System;

namespace _1denNsayısı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir N sayisi giriniz: ");
            int n = 0;
            int toplam = 0;
            int carpım = 0;
            do
            {
                do
                {
                    try
                    {
                        n = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Sadece bir sayi giriniz!");
                    }
                } while (true);
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 1)
                    {
                        toplam += i;
                    }
                    else
                    {
                        carpım += i * i;
                    }
                }
                Console.WriteLine($"Toplam : {toplam}  Çarpım : {carpım}");
                Console.WriteLine("Oyuna devam etmek istermisiniz?E/H ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);
        }
    }
}
