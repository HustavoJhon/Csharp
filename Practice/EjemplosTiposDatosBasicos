//! E03B - EJEMPLOS RESUELTOS OTROS TIPOS DE DATOS BASICOS

//TODO: EJEMPLO 1 - USO DE CARACTERES
//? Escribir un programa que le pida al usuario que introduzca dos letras mayusculas (de la 'A' a la 'Z') y muestre por pantalla las letras que van desde la primera hasta la segunda.
//* Por Ejemplo, si el usuario escribe la 'M' y la 'G', en ese orden , debera sacar por pantalla "M L K J I H G".
//* Si el usuario escribe algo distinto a una letra mayuscula en cualquiera de los dos casos, el programa debe volver a pedirle la letra, hasta que sea correcta.

//TODO: EJEMPLO 2 - USO DE BOOLEANOS
//? Escribe un programa que le pida al usuario 5 numeros enteros y, al finalizar este proceso, le indique si alguno de esos numeros introducidos era impar.

//TODO: EJEMPLO 3 - USO DE ENUMERACIONES
//? Escribe un programa que, utilizando el tipo enumerado (enum), le pida al usuario un numero de mes (DEl 1 al 12) y le muestre cuantos dias tiene ese mes.
//* SI el usuario escribe un numero de mes incorrecto (por ejemplo, 20, 0 -3), le debera mostrar el mensaje "Mes incorrecto"


using System;

class Program1
{
    enum meses { Enero=1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };
    static void Main()
    {
        //EJEMPLO 1
        /*
        char letraInicio, letraFinal, letraActual;

        do
        {
            Console.Write("Escribe una letra mayuscula: ");
            letraInicio = Convert.ToChar( Console.ReadLine());
            if (letraInicio < 'A' || letraInicio > 'Z')
            {
                Console.WriteLine("Letra incorrecta");
            } 
        }while (letraInicio < 'A' || letraInicio > 'Z');

        do
        {
            Console.WriteLine("Escribe otra letra mayuscula: ");
            letraFinal = Convert.ToChar( Console.ReadLine() );
            if (letraFinal < 'A' || letraFinal > 'Z')
            {
                Console.WriteLine("Letra incorrecta");
            } 
        } while (letraFinal < 'A' || letraFinal > 'Z');

        letraActual = letraInicio;
        while (letraActual != letraFinal)
        {
            Console.Write("{0} ", letraActual);
            if (letraInicio < letraFinal)
                letraActual++;
            else
                letraActual--;
        }
        Console.WriteLine(letraActual);
        */

        //EJEMPLO 2
        /*
        const int TOTAL_NUMEROS = 5;
        int numeroActual;
        bool hayNumeroImpar = false;

        Console.WriteLine("Escribe {0} numeros enteros: ", TOTAL_NUMEROS);
        for (int i = 0; i < TOTAL_NUMEROS; i++)
        {
            numeroActual = Convert.ToInt32( Console.ReadLine() );
            if (numeroActual % 2 != 0)
                hayNumeroImpar = true;
        }

        if (hayNumeroImpar)
            Console.WriteLine("Alguno de los numeros es impar");
        else
            Console.WriteLine("Ninguno de los numeros es impar");
        */

        //EJEMPLO 3
        int mes;

        Console.WriteLine("Escribe un numero del 1 al 12: ");
        mes = Convert.ToInt32( Console.ReadLine() );

        switch (mes)
        {
            case (int)meses.Enero:
                Console.WriteLine("Enero tiene 31 dias");
                break;
            case (int)meses.Abril:
            case (int)meses.Junio:
            case (int)meses.Agosto:
            case (int)meses.Octubre:
            case (int)meses.Diciembre:
                Console.WriteLine("Abril, Junio, Agosto, Octubre y Diciembre tienen 30 dias");
                break;
            case (int)meses.Febrero:
                Console.WriteLine("Febrero tiene 28 dias");
                break;
            case (int)meses.Marzo:
            case (int)meses.Mayo:
            case (int)meses.Julio:
            case (int)meses.Septiembre:
            case (int)meses.Noviembre:
                Console.WriteLine("Marzo, Mayo, Julio, Septiembre, Octubre y Noviembre tienen 31 dias");
                break;
            default:
                Console.WriteLine("Mes incorrecto");
                break;
        }
    }
}
