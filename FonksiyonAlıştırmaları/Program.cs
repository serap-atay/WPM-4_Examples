using System;

namespace FonksiyonAlıştırmaları
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int Gortalama = 0,ortlama=0, toplam = 0,enbuyuksayi=0,enkucuksayi=0;
            int sayi = 0;
            int oncekisayi = 0;
            for (int i = 0; i < 5; i++)
            {
                oncekisayi = sayi;
                sayi =rnd.Next(0, 101);
                Console.WriteLine($"rastgele sayi: {sayi}");
                toplam += sayi;
                enbuyuksayi = EnBüyükSayi(oncekisayi, sayi);
                enkucuksayi = EnKucukSayi(oncekisayi, sayi);
                Console.WriteLine($"Enbsayi: {enbuyuksayi}");
                Console.WriteLine($"Enksayi: {enkucuksayi}");
            }
            Gortalama = Ortalama(toplam, 10);
            ortlama = Ortalama((enbuyuksayi + enkucuksayi), 2);
            Console.WriteLine($"Sonuç : {FarkAlma(Gortalama,ortlama)}");

        }
        public static int EnBüyükSayi(int a,int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int EnKucukSayi(int a,int b)
        {
            if (a<b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int Ortalama(int a,int b)
        {
            int sonuc= a / b;
            return sonuc;
        }
        public static int FarkAlma(int a,int b)
        {
            int sonuc = 0;
            if (a>b)
            {
                return sonuc = a - b;
            }
            else
            {
                return sonuc = b - a;
            }
        }
    }
}
