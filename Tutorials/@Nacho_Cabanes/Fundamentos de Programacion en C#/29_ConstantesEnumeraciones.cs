//! 029 -  CONSTANTES Y ENUMERACIONES

// CONSTANTES
//? Una buena practica es crear el nombre de una constante en mayuscula y separado con _
//? las consatnates no se nos permite modificarlas

// ENUMERACIONES
//? Una enumeracion es una lista de valores que se utilizan para representar un conjunto de constantes

using System;

class Constantes1
{
    enum opciones {JUGAR, CARGAR, SALIR};
    enum dias {LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO};
    static void Main()
    {
        int nivelMaximo = 20;

        const int NIVEL_MAXIMO = 20;

        nivelMaximo = 21;
        // NIVEL_MAXIMO = 21;
        Console.WriteLine(opciones.JUGAR);
        Console.WriteLine((int)opciones.JUGAR);

        Console.WriteLine(opciones.CARGAR);
        Console.WriteLine((int)opciones.CARGAR);

        Console.WriteLine(opciones.SALIR);
        Console.WriteLine((int)opciones.SALIR);

        //? EXAMEPLE 1 - CONSTANTES

        const int JUGAR = 1;
        const int CARGAR = 9;
        const int SALIR = 0;

        Console.WriteLine(JUGAR + " Jugar");
        Console.WriteLine(CARGAR + " Cargar");
        Console.WriteLine(SALIR + " Salir");
         
        byte opcion = Convert.ToByte(Console.ReadLine());

        switch (opcion)
        {
            case JUGAR:
                Console.WriteLine("Jugar");
                break;
            case CARGAR:
                Console.WriteLine("Cargar");
                break;
            case SALIR:
                Console.WriteLine("Salir");
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }

        //? EXAMEN 2 - ENUMERACIONES

        Console.WriteLine(dias.LUNES);
        Console.WriteLine((int)dias.LUNES);

        //TODO: EJERCICIO PROPUESTO
        // Crea un juego de adivinar numeros en el que la cantidad de intentos permitida este declarada como una constante
        Console.WriteLine("Adivina el numero");
        const int CANTIDAD_INTENTOS = 5;
        Random random = new Random();

        for (int i = 0; i < CANTIDAD_INTENTOS; i++)
        {
            int numero = random.Next(1, 10);
            Console.WriteLine("Intento #" + (i + 1));
            Console.WriteLine("Ingresa un numero");
            int intento = Convert.ToInt32(Console.ReadLine());
            if (numero == intento)
            {
                Console.WriteLine("Ganaste");
                break;
            }
            else
            {
                Console.WriteLine("Perdiste");
            }
        }
    }
}