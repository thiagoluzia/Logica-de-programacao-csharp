using System;
using System.Globalization;

namespace _1010.Calculo_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int idPeca1, idPeca2, qtPeca1, qtPeca2;
            double precoPeca1, precoPeca2, total;

            string[] vet;

            vet = Console.ReadLine().Split(' ');
            idPeca1 = int.Parse(vet[0]);
            qtPeca1 = int.Parse(vet[1]);
            precoPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            idPeca2 = int.Parse(vet[0]);
            qtPeca2 = int.Parse(vet[1]);
            precoPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = qtPeca1 * precoPeca1 + qtPeca2 * precoPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

            


        }
    }
}
