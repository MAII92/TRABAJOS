using System;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deseas entrar al bucle while!");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("estas ejecutando el interior del bucle while");

                Console.WriteLine("introduce tu nombre por favor");

                string nombre = Console.ReadLine();

                Console.WriteLine($"saldras del bucle{nombre} cuando responda 'no' a la pregunta");

                Console.WriteLine("deseas repetir otra vez");

                respuesta = Console.ReadLine();



            }

            Console.WriteLine("mas solido del buccle");

        }
    }
}