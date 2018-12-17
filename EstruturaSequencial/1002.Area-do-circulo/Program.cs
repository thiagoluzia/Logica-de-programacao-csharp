using System;
using System.Globalization;

namespace _1002.Area_do_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            double n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = n * Math.Pow(raio, 2);
            Console.WriteLine($"A= {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
            
        }
    }
}
