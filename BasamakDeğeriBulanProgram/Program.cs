using System;

namespace BasamakDeğeriBulanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 basamaklı bir sayi giriniz");
            int sayi = 0;
            try
            {

                string text = (Console.ReadLine());
                if (!int.TryParse(text, out  sayi))
                    throw new FormatException(message: "Lütfen 3 basmaklı bir sayi giriniz:");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı bir değer girdiniz.");
            }
            int yuzler = sayi / 100;
            sayi = sayi - yuzler*100;
            int onlar = sayi / 10;
            sayi = sayi - onlar*10;
            int birler = sayi / 1*1;
            sayi = sayi - birler;
            Console.WriteLine($"yüzler: {yuzler} onlar: {onlar} birler: {birler}");

        }
    }
}
