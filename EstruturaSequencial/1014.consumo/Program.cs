using System;
using System.Globalization;

namespace _1014.consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, kmLitro;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            kmLitro = x / y;

            Console.WriteLine($"{kmLitro.ToString("F3", CultureInfo.InvariantCulture)} km/l");
            Console.ReadKey();
        }
    }
}
