//! 012 - EL OPERADOR TERNARIO

using System.Diagnostics.Contracts;

class Ternario()
{
    static void Main()
    {
        int nivel, puntos;

        Console.Write("Dime el nivel: ");
        nivel = Convert.ToInt32( Console.ReadLine() );

        /*
        * CASO 1 
        if (nivel == 1)
        {
            puntos = 10;
        }
        else
        {
            puntos = 20;
        }

        * CASO 2
        if (nivel == 1)
        {
            puntos = 10;
        }
        else if (nivel == 2)
        {
            puntos = 20;
        }
        else
        {
            puntos = 30
        }
        */

        // *TERNARIOS CONCADENADOS 
        //? variable = condicion1 ? valorSiVerdad1: (condicion2 ? valorSiVerdad2: valorSiFalssos);


        puntos = nivel == 1 ? 10 : 20;
        Console.WriteLine("Puntos: {0}", puntos);
        puntos = nivel == 1 ? 10 : ( nivel == 2 ? 20 : 30 );
        Console.WriteLine("Puntos: {0}", puntos);

        /*
        TODO: EJERCICIOS PROPUESTOS
        * Pide al usuario dos numeros enteros. La variable "CantidadDePositivos" devera valer 0, 1 o 2, segun lo que introduzca el usuario

        - n1 y n2 es mayor que 0?
            - n1 es mayor que 0?  retorna 1 si es cierto , sino:
                - n2 es mayor que 0? retornar 1 si es cierto.
        - retornar 0 si todos los numeros anteriores no son positivos
        */

        Console.WriteLine("--EJERCICIO PROPUESTO");

        int n1, n2, resultado;

        Console.Write("Introduce un numero: ");
        n1 = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Introduce el segundo numero: ");
        n2 = Convert.ToInt32( Console.ReadLine() );

        resultado = (n1 > 0 && n2 > 0) ? 2: (n1 > 0)? 1: (n2 > 0)? 1: 0;
        Console.WriteLine("El resultado de tu respues \" {0} - {1} \" es: {2}", n1, n2, resultado);
        
    }
}