﻿namespace buclewhile
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numero= new Random();

            int numeroAleatorio = numero.Next(0, 100);


            Console.WriteLine(numeroAleatorio);
        }
    }
}