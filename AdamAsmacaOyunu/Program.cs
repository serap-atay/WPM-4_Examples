using System;
using System.Collections;

namespace AdamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = new[] { "istanbul", "edirne", "izmir", "bursa", "eskişehir", "balıkesir", "bolu", "sakarya", "kırklareli", "rize" };
            Random rnd = new Random();
            int hak = 5;
            int secim;
            double puan = 0;
            string kelime = null;
            do
            {
                do
                {
                    int rastgelesayi = rnd.Next(0, kelimeler.Length);
                    string secilenkelime = kelimeler[rastgelesayi];
                    char[] bulunanharf = new char[secilenkelime.Length];
                    Console.WriteLine(secilenkelime);
                    Console.WriteLine("1-HARF TAHMİN ET ");
                    Console.WriteLine("2- KELİME TAHMİN ET ");
                    Console.WriteLine("Seçim yapınız: ");
                    do
                    {
                        try
                        {
                            secim = int.Parse(Console.ReadLine());
                            if (secim < 1 || secim > 2)
                                throw new Exception(message: "Lütfen 1 veya 2 numarayı seçiniz.");
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Lütfen bir rakam giriniz:");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    } while (true);
                    if (secim == 1)
                    {

                        char harf = ' ';
                        for (int i = 0; i < secilenkelime.Length; i++)
                        {
                            Console.Write("- ");
                        }
                        Console.WriteLine();         
                        Console.WriteLine("Harf tahmin ediniz: ");
                        for (int i = 0; i < bulunanharf.Length; i++)
                        {
                            do
                            {
                                try
                                {
                                    harf = Convert.ToChar(Console.ReadLine());
                                    if (harf == ' ')
                                        Console.WriteLine("Bir harf giriniz.");
                                    break;

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Lütfen sadece harf giriniz.");

                                }
                            } while (true);
                            if (secilenkelime.Contains(harf))
                            {
                                for (int j = 0; j < secilenkelime.Length; j++)
                                {
                                    if (secilenkelime[j] == harf)
                                    {
                                        
                                        bulunanharf[j] = harf;
                                        Console.Write(bulunanharf[j]);
                                        puan += (j+1) * 10;
                                    }
                                    else
                                    {
                                        bulunanharf[j] ='-';
                                        Console.Write(bulunanharf[j]);

                                    }
                                }
                            }
                            else
                            {
                                hak--;
                                puan=puan- (puan*0.15);
                                if (hak == 0)
                                {
                                    Console.WriteLine("Kaybettiniz.Kalan hakkınız: " + " " + hak);
                                }
                                Console.WriteLine("Yanlış tahmin ettiniz.");
                            }
                        } while (true) ;
                    }
                    else
                    {
                        Console.WriteLine("Kelimeyi tahmin ediniz: ");
                        do
                        {
                            try
                            {
                                kelime = Console.ReadLine();
                                if (kelime == null)
                                    Console.WriteLine("Lütfen bir değer giriniz.");
                                break;
                            }

                            catch (Exception)
                            {
                                Console.WriteLine("Lütfen kelime giriniz.");
                            }
                        } while (true);
                        if (secilenkelime.ToLower() == kelime.ToLower())
                        {
                            Console.WriteLine("TEBRİKLER.Secilen kelime: " + secilenkelime + " kalan hakkınız: " + " " + +hak);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yanlış tahmin ettiniz.Secilen Kelime: " + " " + secilenkelime);
                            break;
                        }
                    }

                } while (true);
                Console.WriteLine("Tekrar oynamak istemisiniz ? E/H");
                if (Console.ReadLine() == "h" || Console.ReadLine() == "H")
                    break;
            } while (true);

        }
    }
}
