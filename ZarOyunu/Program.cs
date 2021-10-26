using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Random rnd = new Random();
                int zar1 = 0;
                int zar2 = 0;
                int zarsayisi = 0;
                int sayac = 0;
                Console.WriteLine("1-6 arası bir zar sayisi giriniz: ");
                do
                {
                    try
                    {
                        zarsayisi = int.Parse(Console.ReadLine());
                        if (zarsayisi < 1 || zarsayisi > 6)
                            throw new Exception(message: "1-6 arası bir sayi giriniz.");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lütfen bir sayi giriniz: ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    } 
                } while (true);
                while (true)
                {
                    sayac++;
                    zar1 = rnd.Next(1, 7);
                    zar2 = rnd.Next(1, 7);
                    Console.WriteLine("1. zarın değeri: " +zar1);
                    Console.WriteLine("2. zarın değeri: " + zar2);
                    if (zar1==zarsayisi && zar2==zarsayisi)
                    {
                        Console.WriteLine(sayac + ". " + "denemede buldunuz.TEBRİKLER.");
                        break;
                    }                  
                }  
                    Console.WriteLine("Devam etmek için 'e' Çıkmak için 'h'  tuşuna basınız...");
                   
            } while (Console.ReadLine()!="h");
           

        }
    }
}
