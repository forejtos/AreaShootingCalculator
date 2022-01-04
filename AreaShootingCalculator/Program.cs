using System;

namespace AreaShootingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double x0;
            double y0;
            double vysledek;
            double pomer;

            const int pokusy = 1000;
            int counter = 0;
            Random random = new Random();

            for (int i = 0; i < pokusy; i++)
            {
                double r = random.NextDouble();
                x = (3 - 1) * r + 1;
                y = random.NextDouble() * 8.0;
                y0 = Math.Pow(2, x);

                if (y < y0)
                {
                    counter++;
                }
                
            }
            pomer = (double)counter / pokusy;
            vysledek = pomer * 16.0;
            Console.Write(pomer);
            Console.ReadKey();
        }
    }
}
