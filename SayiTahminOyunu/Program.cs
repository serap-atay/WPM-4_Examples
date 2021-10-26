using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tutulansayi = rnd.Next(0, 101);
            int tahmin=0;
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Sayi tahmininizi giriniz:");
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin <= 1 || tahmin >= 100)
                            throw new Exception(message: "Lütfen 1-100 arası bir sayi giriniz:");
                        break;      
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Lütfen bir sayi giriniz: ");
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                } while (true);
                if (tahmin == tutulansayi)
                {
                    Console.WriteLine("Tutulan sayi: " + tutulansayi + " TEBRİKLER.");
                    break;
                }
                else if (tahmin < tutulansayi)
                {
                    Console.WriteLine("Tutulan sayi tahmin sayısından büyüktür.");
                }
                else
                {
                    Console.WriteLine("Tutulan sayi tahmin sayisindan küçüktür.");
                }

                Console.WriteLine("Oyuna devam etmek için E tuşuna basınız:");
                ConsoleKeyInfo info = new ConsoleKeyInfo();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);
        }
    }
}

