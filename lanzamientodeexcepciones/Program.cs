namespace lanzamientodeexcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduce numero del mes ");

            int NumeroMes= int.Parse(Console.ReadLine());

            Console.WriteLine(NombreDelMes(NumeroMes));

            Console.WriteLine("aqui continua la ejecucion del resto del programa");
        }

        public static string NombreDelMes(int mes)
        {


            switch (mes) 
            {
               case 1:
                    return "enero";
              
               case 2:

                    return "febrero";
               case 3:

                    return "marzo";
               case 4:

                    return "abril";
              case 5:

                    return "mayo";
              case 6:

                    return "junio";
              case 7:

                    return "julio";
              case 8:

                    return "agosto";
              case 9:

                    return "septiebre";
             case 10:

                    return "octubre";
             case 11:

                    return "noviembre";
             case 12:

                    return "diciembre";

                    



            }
        }
    }
}         