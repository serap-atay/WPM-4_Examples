using System;

namespace SayiTekmiÇiftmi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi=0 ;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bir sayi giriniz: ");
                

                try
                {
                     sayi =int.Parse(Console.ReadLine());
                    if (sayi < 0)
                    {
                        throw new Exception(message: "Lütfen pozitif bir sayi giriniz.");
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi + " sayisi çifttir.");
                }
                else
                {
                    Console.WriteLine(sayi + "sayisi tektir.");
                }


            }
        }
    }
}
