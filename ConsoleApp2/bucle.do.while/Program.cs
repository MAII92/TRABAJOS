namespace bucledowhile;

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

            minumero = int.Parse(Console.ReadLine());

            if (minumero > aleatorio) Console.WriteLine("el numero es mas bajo");

            if (minumero < aleatorio) Console.WriteLine("el numero es mas alto");

        } while (aleatorio != minumero);

        Console.WriteLine($"correcto!mas nececitado {intentos} intentos");


    }
  }
      
