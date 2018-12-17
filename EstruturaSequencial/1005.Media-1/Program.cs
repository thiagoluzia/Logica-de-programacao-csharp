using System;
using System.Globalization;

namespace _1005.Media_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, MEDIA;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((a * 3.5) + (b * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.ReadKey();

        }
    }
}
