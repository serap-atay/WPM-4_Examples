using System;

namespace SwitchCaseAlıstımalar
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize = 0, final = 0,ortalama=0;
            int islem = 0;
            try
            {
            
                Console.WriteLine("Öğrencinin sınav notunu giriniz: ");
                bool dogrumu = double.TryParse(Console.ReadLine(), out vize);
                Console.WriteLine("Öğrencinin final notunu giriniz: ");
                dogrumu = double.TryParse(Console.ReadLine(), out final);
                if (!dogrumu)
                {
                    throw new FormatException(message: "Sadece sayi girisi yapınız!");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
            }
            ortalama = Ortalama(vize, final);
            if (ortalama==50)
            {
                islem =1;
            }
            else if (ortalama>50 && ortalama <70)
            {
                islem = 2;
            }
            else if (ortalama > 70 && ortalama< 90)
            {
                islem = 3;
            }
            else if(ortalama>90 && ortalama<=100)
            {
                islem = 4;
            }
            else
            {
                islem = 5;
            }
            switch (islem)
            {
                case 1:
                    Console.WriteLine($" Ortalama : {ortalama} - CC.");
                    break;
                case 2:
                    Console.WriteLine($" Ortalama : {ortalama} - BB.");
                    break;
                case 3:
                    Console.WriteLine($" Ortalama : {ortalama} - BA.");
                    break;
                case 4:
                    Console.WriteLine($" Ortalama : {ortalama} - AA.");
                    break;

                default:
                    Console.WriteLine("Kaldınız.");
                    break;
            }

        }
        public static double Ortalama(double a,double b)
        {
          double ortalama = (a * 0.3) + (b * 0.7);
            return ortalama;
        }
    }
}
