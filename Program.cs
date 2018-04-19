using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v programu pro výpočet soustavy tří rovnic o třech neznámých pomocí Cramerova pravidla.");
            Console.WriteLine("Máme tři rovnice ve tvaru: A*(x1) + B*(x2) + C*(x3)= D");
            Console.WriteLine("Já vás poprosím o zadání hodnot A,B,C a D a ukážu vám výsledky x1,x2 a x3.");
            Console.WriteLine("\nPRVNÍ ROVNICE:");
            Console.WriteLine("A:");
            double A1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B:");
            double B1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("C:");

            double C1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("D:");
            double D1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDRUHÁ ROVNICE:");
            Console.WriteLine("A:");
            double A2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B:");
            double B2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("C:");
            double C2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("D:");
            double D2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTŘETÍ ROVNICE:");
            Console.WriteLine("A:");
            double A3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B:");
            double B3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("C:");
            double C3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("D:");
            double D3 = Convert.ToDouble(Console.ReadLine());

            double determinantMatice = 
                ((A1 * B2 * C3) + (A3 * B1 * C2) + (A2 * B3 * C1)) 
                - ((A3 * B2 * C1) + (A2 * B1 * C3) + (A1 * B3 * C2));
            Console.WriteLine($"Determinant matice = {determinantMatice}");

            double determinantMaticeA1 =
                ((D1 * B2 * C3) + (D3 * B1 * C2) + (D2 * B3 * C1))
                - ((D3 * B2 * C1) + (D2 * B1 * C3) + (D1 * B3 * C2));
            Console.WriteLine($"Determinant matice A1 = {determinantMaticeA1}");

            double determinantMaticeA2 =
                ((A1 * D2 * C3) + (A3 * D1 * C2) + (A2 * D3 * C1))
                - ((A3 * D2 * C1) + (A2 * D1 * C3) + (A1 * D3 * C2));
            Console.WriteLine($"Determinant matice A2 = {determinantMaticeA2}");

            double determinantMaticeA3 =
                ((A1 * B2 * D3) + (A3 * B1 * D2) + (A2 * B3 * D1))
                - ((A3 * B2 * D1) + (A2 * B1 * D3) + (A1 * B3 * D2));
            Console.WriteLine($"Determinant matice A3 = {determinantMaticeA3}");

            double x1 = determinantMaticeA1 / determinantMatice;
            x1 = Math.Round(x1, 4);
            double x2 = determinantMaticeA2 / determinantMatice;
            x2 = Math.Round(x2, 4);
            double x3 = determinantMaticeA3 / determinantMatice;
            x3 = Math.Round(x3, 4);

            Console.WriteLine($"Řešením této soustavy jsou čísla: {x1}; {x2}; {x3}.");

            Console.WriteLine("Ukončíte stiknutím libovolné klávesy.");
            Console.Read();
        }
    }
}
