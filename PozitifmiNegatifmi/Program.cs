using System;

namespace PozitifmiNegatifmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi =0;
            do
            {

                Console.WriteLine("Bir sayi giriniz:");
                do
                {
                    try
                    {
                        sayi = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("Yüksek bir değer girdiniz.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Lütfen bir sayi giriniz!");
                        
                    }
                } while (true);
                if (sayi == 0)
                {
                    Console.WriteLine($"Girilen {sayi} sayisi 0 dır.");
                    break;
                }
                else if (sayi < 0)
                    Console.WriteLine($"Girilen {sayi} sayisi negatiftir.");
                else
                    Console.WriteLine($"Girilen {sayi} sayisi pozitiftir.");
                Console.Write("Oyuna devam etmek için E ye basınız:");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key==ConsoleKey.H)
                {
                    break;
                }
            } while (true);
        }
    }
}
