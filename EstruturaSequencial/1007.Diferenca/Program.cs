﻿using System;

namespace _1007.Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, DIFERENCA;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            DIFERENCA = ((a * b) - (c * d));

            Console.WriteLine($"DIFERENCA = {DIFERENCA.ToString()}");
            Console.ReadKey();
        }
    }
}
