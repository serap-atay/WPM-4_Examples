using System;

namespace BomOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU-1 5 ve 5'in katları bom
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine("BOM");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //SORU-2 Bom sayısı kullanıcı tarafından girilen Bom
            //Console.WriteLine("BOM sayisini giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < =100; i++)
            //{
            //    if (i%sayi==0)
            //    {
            //        Console.WriteLine("BOM");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //SORU-3 BOM sayisi kulanıcı girişli oyunu bilgisayarın başlatması
            Console.WriteLine("BOM sayisi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    if (i % sayi == 0)
                    {
                        Console.WriteLine("BOM");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }
                else
                {

                    Console.WriteLine("Sıra sizde : ");
                    if (i % sayi == 0)
                    {
                        if("BOM"==Console.ReadLine() || "bom" == Console.ReadLine())
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Oyunu kaybettiniz.");
                            break;
                        }

                    }
                    else
                    {
                        if (i==Convert.ToInt32( Console.ReadLine()))
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Oyunu kaybettiniz.");
                            break;
                        }
                    }

                
                }
            }
            Console.WriteLine("Oyun berabere.");

        }

    }
}


