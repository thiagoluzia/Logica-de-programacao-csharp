﻿using System;

namespace _1003.Soma_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, SOMA;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            SOMA = a + b;
            Console.WriteLine($"SOMA = {SOMA.ToString()}");
            Console.ReadKey();
        }
    }
}