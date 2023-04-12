using System.Runtime.CompilerServices;

namespace condicional3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce el primer parcial");

            int parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("introduce el segundo parcial");

            int parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("introduce el tercer  parcial");
            
            int parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)

                Console.WriteLine("la nota media es" + (parcial1 + parcial2 + parcial3) / 3);

            else Console.WriteLine("vuelve en septiembre");

        }
    }
}