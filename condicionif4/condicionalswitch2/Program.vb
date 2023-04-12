Using System

Namespace condicionalswitch2
{
   Class Program
   {
        Static void Main(String[] args)
         {
            Console.WriteLine("Introduce n° de  mes para calculo de comision;");

           Int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
             {
             Case 1 :  
               Console.WriteLine ("Mes escogico: Enero);
                break;

                case 2:
               Console.WriteLine ("Mes escogico febrero);
                break;

                Case 3 :   
               Console.WriteLine ("Mes escogico: marzo);
                brea

               case 4:
               Console.WriteLine ("Mes escogico abril);
                break;

               Case 5 :      
               Console.WriteLine ("Mes escogico: mayo);
                break;

             case 6:
               Console.WriteLine ("Mes escogico junio);
                break;

                Case 7 :       
               Console.WriteLine ("Mes escogico: julio);
                break;

                Case 8:  
               Console.WriteLine ("Mes escogico agosto);
                break;

                 Case 9 :        
               Console.WriteLine ("Mes escogico: septiebre);
                break;

               case 10:
               Console.WriteLine ("Mes escogico octubre);
                break;

                 Case 11 :    
               Console.WriteLine ("Mes escogico: noviembre);
                break;


                 case 12:  
               Console.WriteLine ("Mes escogico diciembre);
                break;

                   Default:    

                    Console.Writeline("mes incorrecto")
              }
   }                     Cosole.WriteLine("ha terminado el programa");
}         }