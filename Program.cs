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
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C:");

            int C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D:");
            int D1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDRUHÁ ROVNICE:");
            Console.WriteLine("A:");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            int B2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C:");
            int C2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D:");
            int D2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTŘETÍ ROVNICE:");
            Console.WriteLine("A:");
            int A3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B:");
            int B3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C:");
            int C3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("D:");
            int D3 = Convert.ToInt32(Console.ReadLine());

            int determinantMatice = 
                ((A1 * B2 * C3) + (A3 * B1 * C2) + (A2 * B3 * C1)) 
                - ((A3 * B2 * C1) + (A2 * B1 * C3) + (A1 * B3 * C2));
            Console.WriteLine($"Determinant matice = {determinantMatice}");

            int determinantMaticeA1 =
                ((D1 * B2 * C3) + (D3 * B1 * C2) + (D2 * B3 * C1))
                - ((D3 * B2 * C1) + (D2 * B1 * C3) + (D1 * B3 * C2));
            Console.WriteLine($"Determinant matice A1 = {determinantMaticeA1}");

            int determinantMaticeA2 =
                ((A1 * D2 * C3) + (A3 * D1 * C2) + (A2 * D3 * C1))
                - ((A3 * D2 * C1) + (A2 * D1 * C3) + (A1 * D3 * C2));
            Console.WriteLine($"Determinant matice A2 = {determinantMaticeA2}");

            int determinantMaticeA3 =
                ((A1 * B2 * D3) + (A3 * B1 * D2) + (A2 * B3 * D1))
                - ((A3 * B2 * D1) + (A2 * B1 * D3) + (A1 * B3 * D2));
            Console.WriteLine($"Determinant matice A3 = {determinantMaticeA3}");

            Console.WriteLine("Ukončíte stiknutím libovolné klávesy.");
            Console.Read();
        }
    }
}
