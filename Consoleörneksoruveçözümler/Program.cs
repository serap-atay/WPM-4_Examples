using System;

namespace Consoleörneksoruveçözümler
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                do
                {
                    //SORU-3 girilen sayının asal olup olmadığını bulma
                    Console.WriteLine("Bir sayi giriniz:");
                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi == 2)
                    {
                        Console.WriteLine(sayi + " sayisi asal sayıdır.");
                    }
                    else
                    {
                        for (int i = 2; i < sayi; i++)
                        {
                            if (sayi % i == 0)
                            {
                                Console.WriteLine(sayi + "sayisi asal değildir.");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine($"{sayi} - sayisi asal sayıdır.");
                        break;
                    }
   
                } while (true);
                Console.WriteLine("Oyuna devam etmek için E tuşuna basınız:");
            } while (Console.ReadLine()!="h");
        }
    }
}
