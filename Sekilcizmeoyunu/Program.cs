using System;

namespace Sekilcizmeoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("**** Oyun Menüsü ******");
                Console.WriteLine("1- KARE ÇİZME");
                Console.WriteLine("2-İÇİ BOŞ KARE ÇİZME");
                Console.WriteLine("3- ÜÇGEN ÇİZME");
                Console.WriteLine("4-ÇIKIŞ");
                Console.WriteLine("İŞLEM numarası seçiniz: ");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1)
                {
                    Console.WriteLine("kare kenar uzunluğunu giriniz: ");
                    int kenar = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < kenar; i++)
                    {
                        for (int j = 0; j < kenar; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("");
                }
                else if(islem==2)
                {
                    Console.WriteLine("Karenin kenar uzunluğunu giriniz:");
                    int kenar = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < kenar; i++)
                    {
                        for (int j = 0; j < kenar; j++)
                        {
                            if(i==0 || j==3 )
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                    
                }
                else if (islem==3)
                {

                }
                else
                {
                    break;
                }
             } while (true);
        }
    }
}
