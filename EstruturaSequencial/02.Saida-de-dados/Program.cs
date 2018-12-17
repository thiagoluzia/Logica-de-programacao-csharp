using System;
using System.Globalization;

namespace _02.Saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x + " = USANDO + PARA CONCATENAR");
            Console.WriteLine($"O valor do troco é {x} reais = USANDO $ NO INICIO PARA CONCATENAR");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais = USANDO F2");
            Console.WriteLine("O valor do troco é " + x.ToString("N2") + " reais =  USNADO N2");
            Console.WriteLine("O valor do troco é " + x.ToString("C2") + " = USANDO C2");

            Console.WriteLine();
            Console.WriteLine("A paciente {0} tem {1} anos e seu sexo é: {2}", z, y, w + " = USANDO PASSAGEM DE PARAMETROS PARA CONCATENAR");

            Console.ReadLine();
        }
    }
}
