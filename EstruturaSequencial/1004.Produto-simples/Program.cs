using System;

namespace _1004.Produto_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, PRODUTO;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PRODUTO = a * b;
            Console.WriteLine($"PROD = {PRODUTO.ToString()}");
            Console.ReadKey();
        }
    }
}
