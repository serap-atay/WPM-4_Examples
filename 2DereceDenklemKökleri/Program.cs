using System;

namespace _2DereceDenklemKökleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A değerini giriniz: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("B değerini giriniz: ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("C değerini giriniz: ");
            double c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Denklem = {a}x2+ {b}x+ {c}");
            double diskriminant = (b * b) - (4 * a * c);
            Console.WriteLine($"Diskriminant: {diskriminant}");
            if (diskriminant<0)
            {
                Console.WriteLine("Denklem kökü yoktur.");
            }
            else if (diskriminant==0)
            {
                double kök1 = (-b - Math.Sqrt(diskriminant)) / 2 * a;
                Console.WriteLine($"Denklemin bir kökü vardır.Kök: {kök1}");
            }
            else
            {
                double kök1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
                double kök2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
                Console.WriteLine($"Denklemin iki kökü vardır. Kök 1 : {kök1} - Kök2: {kök2}");
            }
        }
    }
}
