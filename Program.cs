using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalaluApp
{

    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine(" -  Vitej ve vypoctarne  -");
            Console.WriteLine(" -     Zvol moznost:     -");
            Console.WriteLine(" -     [1] Vypocet       -");
            Console.WriteLine(" -     [2] Konec         -");
            Console.WriteLine();

            string vyber = Console.ReadLine();

            switch (vyber)
            {                                                    //switch MENU  

                case "1":
                    Console.WriteLine("Máme tři rovnice ve tvaru: A*(x1) + B*(x2) + C*(x3)= D");
                    Console.WriteLine("Zadejte hodnoty A,B,C a D pro každou rovnici a ukážu vám výsledky x1,x2 a x3.");

                    //Zadávání tří rovnic o třech neznámých:
                    Console.WriteLine("\nPRVNÍ ROVNICE:");
                    Console.WriteLine("A:");
                    double A1 = Convert.ToDouble(Console.ReadLine()); //input A1
                    Console.WriteLine("B:");
                    double B1 = Convert.ToDouble(Console.ReadLine()); //input B1
                    Console.WriteLine("C:");
                    double C1 = Convert.ToDouble(Console.ReadLine()); //input C1
                    Console.WriteLine("D:");
                    double D1 = Convert.ToDouble(Console.ReadLine()); //input D1

                    Console.WriteLine("\nDRUHÁ ROVNICE:");
                    Console.WriteLine("A:");
                    double A2 = Convert.ToDouble(Console.ReadLine()); //input A2
                    Console.WriteLine("B:");
                    double B2 = Convert.ToDouble(Console.ReadLine()); //input B2
                    Console.WriteLine("C:");
                    double C2 = Convert.ToDouble(Console.ReadLine()); //input C2
                    Console.WriteLine("D:");
                    double D2 = Convert.ToDouble(Console.ReadLine()); //input D2

                    Console.WriteLine("\nTŘETÍ ROVNICE:");
                    Console.WriteLine("A:");
                    double A3 = Convert.ToDouble(Console.ReadLine()); //input A3
                    Console.WriteLine("B:");
                    double B3 = Convert.ToDouble(Console.ReadLine()); //input B3
                    Console.WriteLine("C:");
                    double C3 = Convert.ToDouble(Console.ReadLine()); //input C3
                    Console.WriteLine("D:");
                    double D3 = Convert.ToDouble(Console.ReadLine()); //input D3

                    //Výpočet determinantu matice:
                    double determinantMatice =
                        ((A1 * B2 * C3) + (A3 * B1 * C2) + (A2 * B3 * C1))
                        - ((A3 * B2 * C1) + (A2 * B1 * C3) + (A1 * B3 * C2));
                    Console.WriteLine($"Determinant matice = {determinantMatice}");

                    //Výpočet determinantu matice s nahrazeným prvním sloupcem:
                    double determinantMaticeA1 =
                        ((D1 * B2 * C3) + (D3 * B1 * C2) + (D2 * B3 * C1))
                        - ((D3 * B2 * C1) + (D2 * B1 * C3) + (D1 * B3 * C2));
                    Console.WriteLine($"Determinant matice A1 = {determinantMaticeA1}");

                    //Výpočet determinantu matice s nahrazeným druhým sloupcem:
                    double determinantMaticeA2 =
                        ((A1 * D2 * C3) + (A3 * D1 * C2) + (A2 * D3 * C1))
                        - ((A3 * D2 * C1) + (A2 * D1 * C3) + (A1 * D3 * C2));
                    Console.WriteLine($"Determinant matice A2 = {determinantMaticeA2}");

                    //Výpočet determinantu matice s nahrazeným třetím sloupcem:
                    double determinantMaticeA3 =
                        ((A1 * B2 * D3) + (A3 * B1 * D2) + (A2 * B3 * D1))
                        - ((A3 * B2 * D1) + (A2 * B1 * D3) + (A1 * B3 * D2));
                    Console.WriteLine($"Determinant matice A3 = {determinantMaticeA3}");

                    //Deklarace a výpočet x1:
                    double x1 = determinantMaticeA1 / determinantMatice;
                    //Zaokrouhlení x1 na 4 desetinná místa:
                    x1 = Math.Round(x1, 4);
                    //Deklarace a výpočet x2:
                    double x2 = determinantMaticeA2 / determinantMatice;
                    //Zaokrouhlení x2 na 4 desetinná místa:
                    x2 = Math.Round(x2, 4);
                    //Deklarace a výpočet x3:
                    double x3 = determinantMaticeA3 / determinantMatice;
                    //Zaokrouhlení x3 na 4 desetinná místa:
                    x3 = Math.Round(x3, 4);

                    //Výpis výsledků:
                    Console.WriteLine($"Řešením této soustavy jsou čísla: {x1}; {x2}; {x3}.");
                    Console.WriteLine("\n Stisknete klavesu pro navrat do menu");
                    Console.ReadLine();
                    goto start;

                case "2":                                                                               //Ukonci program
                    break;
            }
        }        
    }
}
