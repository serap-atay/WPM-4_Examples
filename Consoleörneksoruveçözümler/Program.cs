using System;

namespace Consoleörneksoruveçözümler
{
    class Program
    {
        static void Main(string[] args)
        {
            // SORU-1 girilen 10 sayının çift mi tek mi olduğunu bulan program
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Bir sayi giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine(sayi + " sayisi çifttir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi + "sayisi tektir.");
            //    }
            //}

            //SORU-2 girilen 5 sayının toplamını bulan program
            //int toplam = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("bir sayi giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //}
            //Console.WriteLine("Toplam :"+ toplam);

            //SORU-3 girilen sayının asal olup olmadığını bulma
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 2)
            {
                Console.WriteLine(sayi + " sayisi asal sayıdır.");
            }
            else
            {
                 for (int i = 2; i < sayi; i++)
                {
                    if (sayi%i==0)
                    {
                        Console.WriteLine(sayi+"sayisi asal değildir.");
                        break;
                    }
                    else
                    {

                        if (sayi == i+1)
                        {
                            Console.WriteLine(sayi +"sayisi asaldır.");
                        }
                        continue;
                    }
                             
                }

               
            }
          
           
        }
    }
}
