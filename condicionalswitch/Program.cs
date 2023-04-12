namespace condicionalswitch
{
   class Program
   { 
   
        static void Main(string[] args)
        {
            Console.WriteLine("Elige medio de transporte (coche ,tren ,avion)");

            string medioTransporte = Console.ReadLine();
            {
                switch (medioTransporte)
                {

                    case "coche":
                        Console.WriteLine("velocidad media: 100 km/h)");
                        break;


                    case "tren":
                        Console.WriteLine("velocidad media : 250 km/h");
                        break;

                    case "avion":
                        Console.WriteLine("velocidad media: 800 km/h");
                        break;
                }
            }
        }
   }
 }


