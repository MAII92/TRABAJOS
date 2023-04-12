namespace exception2;

class Program
{
    static void Main(string[] args)

    {

        Random numero = new Random();

        int aleatorio = numero.Next(0, 100);

        int minumero = 101;

        int intentos = 0;

        Console.WriteLine("introduce un n° entre 0 y 100");



        do
        {


            intentos++;

            try
            {
                minumero = int.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("No ha habido un error se toma como numero introducido el 0");
                //Console.WriteLine(ex.Message);
                minumero = 0;

            }

            catch (FormatException e)
            {
                Console.WriteLine("has introducido texto");

                minumero = 0;
            }
             


                   if (minumero > aleatorio) Console.WriteLine("el numero es mas bajo");

                   if (minumero < aleatorio) Console.WriteLine("el numero es mas alto");

        } while (aleatorio != minumero);


                   Console.WriteLine($"correcto!mas nececitado {intentos} intentos");

                   Console.WriteLine("apartir de esta linea de codigo el programa continuaria");

}   }
