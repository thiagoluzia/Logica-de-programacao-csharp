using System;
using System.Globalization;

namespace _1008.Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, nHoras;
            double valorHora, salario;

            id = int.Parse(Console.ReadLine());
            nHoras = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = nHoras * valorHora;

            Console.WriteLine($"NUMBER = {id}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
