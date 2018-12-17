using System;

namespace _1016.Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;
            // Raciocinio: se o carro Y consegue se afastar 1 km a cada 2 minutos,
            // para descobrir o tempo basta multiplicar a distancia por 2

            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;

            Console.WriteLine($"{tempo.ToString()}  minutos");
            Console.ReadKey();

        }
    }
}
