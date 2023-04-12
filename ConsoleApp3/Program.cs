using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)

        {
            const double PI = 3.1416;

            Console.WriteLine("inroduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            double area = radio * radio * PI;

            Console.WriteLine($"El area del circulo es {area}");
              
        }
    }
}


