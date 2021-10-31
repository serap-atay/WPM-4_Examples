using System;

namespace FabrikaİsciUcretiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşçinin çalıştığı saat: ");
            int calisilansaat = 0;
            int saatücreti = 20;
            int maas=0;
            try
            {
                calisilansaat = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen istenilen bilglileri giriniz.");
            }
            if (calisilansaat<40)
            {
                maas = calisilansaat * saatücreti;
            }
            else
            {
                maas = (calisilansaat * saatücreti) * 2;
            }
            Console.WriteLine($"Maaş:  {maas}");
        }
    }
}
