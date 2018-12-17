using System;
using System.Globalization;

namespace _1006.Media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, MEDIA;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
