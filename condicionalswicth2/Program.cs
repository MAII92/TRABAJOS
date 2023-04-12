

using System;

namespace condicionalswitch2
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Introduce n° de  mes para calculo de comision;");

            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Mes escogico: Enero");
                    break;

                case 2:
                    Console.WriteLine("Mes escogico febrero");
                    break;

                case 3:
                    Console.WriteLine("Mes escogico: marzo");
                    break;

                case 4:
                    Console.WriteLine("Mes escogico abril");
                    break;

                case 5:
                    Console.WriteLine("Mes escogico: mayo");
                    break;

                case 6:
                    Console.WriteLine("Mes escogico junio");
                    break;


                case 7:
                    Console.WriteLine("Mes escogico: julio");
                    break;

                case 8:
                    Console.WriteLine("Mes escogico agosto");
                    break;

                case 9:
                    Console.WriteLine("Mes escogico: septiebre");
                    break;

                case 10:
                    Console.WriteLine("Mes escogico octubre");
                    break;

                case 11:
                    Console.WriteLine("Mes escogico: noviembre");
                    break;


                case 12:
                    Console.WriteLine("Mes escogico diciembre");
                    break;

                default:
                    Console.WriteLine("mes incorrecto");
                    break;

                    Console.WriteLine("ha terminado el programa");
                    break;


            }
        }
    }
}