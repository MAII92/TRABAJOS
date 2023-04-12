namespace condition9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("introduce tu edad por favor ");

            int edad = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("¿tienes carnet?");

            string carnet = Console.ReadLine();

            int compara = string.Compare(carnet, "si ", true);

            if (compara == 0) Console.WriteLine("puedes conducir vehiculos ");

            else Console.WriteLine("lo siento mucho no puedes conducir ");

        }
    }
}