using System;

namespace ejemploPOO

{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creacion de objeto de tipo circulo.variable/objeto de tipo circulo

           miCirculo = new Circulo();  // iniciacion de variable/objeto de tipo circulo.Instanciar una clase

            Console.WriteLine(miCirculo.calculoArea(5));
               
            Circulo micirculo2= new Circulo();

            Console.WriteLine(micirculo2.calculoArea(9));

            miciculo.pi =50,45;
        }
        class Circulo
    }
    public double pi = 3.1416; // propiedad de la clase de circulo.campo de clase.

    public double CalculoArea(int radio) // metdodo de clase.¿que pueden hacer los objetos de tipo circulo?
    {
        return pi * radio * radio;

    }




}