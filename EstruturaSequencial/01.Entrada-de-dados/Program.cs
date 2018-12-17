using System;
using System.Globalization;

namespace _01.Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1
            string x;
            int y;
            double z;
            char w;

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(w);

            //Exemplo2
            Console.WriteLine("Com vetores");

            string[] vet = Console.ReadLine().Split(' ');

            x = vet[0];
            y = int.Parse(vet[1]);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);
            w = char.Parse(vet[3]);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(w);


            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
