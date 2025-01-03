//! E02b - Ejemplos de estructuras repetitivas

//? CONSIDERACIONES PREVIAS

//* Utilizaremos estructuras WHILE cuando no sepamos cuantas repeticiones vamos a realizar, ni siquiera si hablra alguna repeticion

//* Utilizamos estructuras DO..WHILE cuando no sepamos cuantas repeticiones vamos a realizar, pero sabemos que al menos habra una

//* Utilizaremos estructuras FOR cuando sepamos de antemoano cuantas repeticiones haremos


using System;

class Atras
{
    public static void Main (string[] args)
    {
        Console.WriteLine("EJEMPLO 1");
        // Escribe un programa que le pida al usuario un numero, y despues realice la cuenta atras desde ese numero hasta 0.
        int numero;

        Console.WriteLine("Introduce el numero para contar: ");
        numero = Convert.ToInt32( Console.ReadLine() );

        while (numero >= 0)
        {
            Console.WriteLine(numero);
            numero = numero -1; //n--
        }
        Console.WriteLine("Fin del programa");


        Console.WriteLine("EJEMPLO 2");
        // Escribe un programa que le pida al usuario que adivine un numero entero entre 1 y 100 (dicho numero se quedara prefijado previamente en una variable). En cada intento, el programa informara al usuario si el numero buscado es menor o mayor que el introducido

        const int numeroSecreto = 78;
        int numeroUsuario;

        do
        {
            Console.Write("Introduce el numero secreto: ");
            numeroUsuario = Convert.ToInt32( Console.ReadLine() );

            if (numeroUsuario < numeroSecreto)
            {
                Console.WriteLine("El numero buscado es mayor");
            }
            else if (numeroUsuario > numeroSecreto)
            {
                Console.WriteLine("El numero buscado es menor");
            }
            else
            {
                Console.WriteLine("Has acertado!");
            }
        } while (numeroUsuario != numeroSecreto);

        Console.WriteLine("EJEMPLO 3");
        // Escribr un programa que le pida al usuario dos numeros: una base y un exponente, y calcule la potencia (base elevado a exponente), realizando para ello multiplicaciones sucesivas.

        int numeroBase, numeroExponente, resultado;

        Console.Write("Escribe la base: ");
        numeroBase = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Escribe el exponente: ");
        numeroExponente = Convert.ToInt32( Console.ReadLine() );

        if (numeroExponente < 0)
        {
            Console.WriteLine("Imposible calcular potencia entera");
        }
        else
        {
            resultado = 1;

            for (int i = 1; i <= numeroExponente; i++)
            {
                resultado = resultado * numeroBase;
            }
            Console.WriteLine("Resultado: {0}", resultado);
        }

        Console.WriteLine("EJEMPLO 4");
        //Escribe un programa que le pida al usuario una altura, y dibuje triangulo asteriscos con esa altura. Por ejemplo, si el usuario indica una altura de 4, el triangulo resultante debera quedar asi: */**/***/****
        //PLANTEAMIENTO: 
        // - Para dibujar figuras bidimensionales, es necesario siempre un doble bucle:
        // - El primer bucle (el externo) se encargara de ir fila a fila
        // - El segundo bucle  (el interno) se encargara de dibujar los elementos de cada fila
        int alturaTriangulo;

        Console.Write("Introduce la altura del triangulo: ");
        alturaTriangulo = Convert.ToInt32( Console.ReadLine() );

        //primer bucle: va fila por fila
        for (int i = 0; i < alturaTriangulo; i++)
        {
            //segundo bucle: rellena cada fila
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("EJEMPLO 5");
        // Escribe un programa que le pida al usuario un numero, y muestre por pantalla si dicho numero es primo o no. Recuerda que un numero primo solo es divisible entre el mismo y entre 1.
        // PLANTEAMIENTO
        // - Para determinar si un numero es primo o no, debemos ver si es divisible por algun numero entre el 2 y el numero -1. Si hay algun divisor en ese rango, no sera primo.
        int number, contador = 2, totalDivisores = 0;

        Console.Write("Escribe un numero: ");
        number = Convert.ToInt32( Console.ReadLine() );

        while (contador < numero && totalDivisores == 0)
        {
            if (number % contador == 0)
            {
                totalDivisores++;
            }
            contador++;
        }
        if (totalDivisores > 0)
        {
            Console.WriteLine("No es primo");
        }
        else
        {
            Console.WriteLine("Es primo");
        }
    }
}