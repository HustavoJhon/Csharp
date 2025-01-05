//! 048 - FUNCIONES QUE DEVUELVEN UN VALOR. VARIABLES LOCALES

/* DEVOLVER UN VALOR
* Las funcinoes pueden devolver un valor (un resultado):

static int Cuadrado ( int n)
{
    return n*n;
}

* Que se podria usar asi:
    int resultado = Cuadrado(5);
*/

// EJEMPLO RESUELTO
//? Una funcion potencia (a,b) que devuelva el resultado de elvar un numero entero "a" a otro entero (no negativo) "b"

/* VARIABLES LOCALES
* Solo existen dentro de una funcion. No seran accesibles desde fuera:
*/

using System;
/*
class FuncionesValor
{
    static int Potencia(int a, int b)
    {
        int resultadoTemporal1 = 1;
        for (int i = 0; i < b; i++)
        {
            resultadoTemporal1 *= a;
        }
        return resultadoTemporal1;
    }
    static void Main()
    {
        int n = Potencia(2, 3);
        Console.WriteLine(n);
    }
}
*/

// TODO: EJERCICIO PROPUESTO
//? Crea una funcion llamada "EsPrimo", que devolvera true si el parametro es un numero primo, o false en caso contrario.

using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        int numero = 29;
        bool esPrimo = EsPrimo(numero);
        Console.WriteLine($"¿El número {numero} es primo? {esPrimo}");
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
