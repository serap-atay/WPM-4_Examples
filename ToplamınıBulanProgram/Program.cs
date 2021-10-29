using System;

namespace ToplamınıBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           // SORU - 2 girilen 5 sayının toplamını bulan program
            int toplam = 0;
            int sayi = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("bir sayi giriniz:");
                try
                {
                    if (!int.TryParse(Console.ReadLine(), out sayi))
                        throw new Exception(message: "lÜtfen sadece sayi giriniz.");
                }

                catch (Exception)
                {
                    Console.WriteLine("Lütfen geçerli bir sayi giriniz.");
                }

                toplam += sayi;
            }
            Console.WriteLine("Toplam :" + toplam);

        }
    }
}
