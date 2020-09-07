using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Nico Bauer
/// IS218
/// AWE
/// Potenzen berechnen
/// </summary>

namespace Potenz
{
    class Program
    {
        static void Main(string[] args)
        {
            double basis = 0;
            double potenz = 0;
            int zähler = 1;
            string weitermachen = "";

            do
            {
                Console.WriteLine("\nBitte geben Sie die erste Zahl ein.");
                basis = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ihre Basis lautet: {0}", basis);
                double x = basis;

                Console.WriteLine("\nBitte geben Sie die zweite Zahl ein.");
                potenz = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ihre Potenz lautet: {0}", potenz);

                while (zähler < potenz)
                {
                    basis *= x;
                    zähler++;
                }


                /*for(; zähler < potenz ; zähler++)
                {
                    basis *= x;
                }
                

                do
                {
                    basis *= x;
                    zähler++;
                }
                while (zähler < potenz);
                */
                

                Console.WriteLine("\nErgebnis: {0}" ,basis);

                Console.WriteLine("\nGeben Sie bitte (j) ein, um eine weitere Potenz ausrechnen zu lassen.");
                weitermachen = Console.ReadLine();
            }
            while (weitermachen == "j");
        }
    }
}
