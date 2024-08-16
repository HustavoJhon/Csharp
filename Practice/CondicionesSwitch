//! 011 - CONDICIONES CON SWITCH

using System;

class Condiciones
{
    static void Main()
    {
        int mes;

        Console.Write("Indique el numero del mes: ");
        mes = Convert.ToInt32( Console.ReadLine() );

        switch( mes )
        {
            case 1 :
                Console.WriteLine("Quisas sea Enero...");
                goto case 2 ; //? goto case para que un caso delegue en otro
                // Console.WriteLine("Enero");
                // break;
                //? es siempre necesario el break para cerrar la condicion tambien podemos porner sin nd dentro de case 1 para que no nos marque error
            case 2 :
                Console.WriteLine("Febrero");
                break;
            case 3 :
                Console.WriteLine("Marzo");
                break;
            default :
                Console.WriteLine("No se cual es");
                break;
        }

        /*
        TODO: EJERCICIO PROPUESTO
        * Pide al usuario el numero de un dia de la semana y muestra el nombre de ese dia (o un mensaje de aviso, si se trata de un nombre incorrecto)
        */
        int dia;

        Console.Write("Escribe el numero de un dia: ");
        dia = Convert.ToInt32( Console.ReadLine() );

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;

            default:
                Console.WriteLine("No hay ese dia de la semana");
                break;
        }
    }
}