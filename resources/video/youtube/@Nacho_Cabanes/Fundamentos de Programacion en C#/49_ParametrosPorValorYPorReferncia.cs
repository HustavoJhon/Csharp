//! 049 PARAMETROS POR VALOR Y POR REFERENCIA

/* MODIFICAR PARAMETROS
* Hasta ahora hemos pasado parametros "por valor": si hacemos cambios, no se guardan

? Alternativa: usar la palabra "ref" ("por referencia")

static void Duplicate (ref int x)
*/

/* CUANDO USAR "REF"?
* "ref" se usa cuando:

? Necesitamos devolver dos o mas valores de una funcion

? Ncesitamos optimizar la velocidad, evitando la creacion de una copia de una gran estructura de datos (en lenguajes "antiguos")
*/

/* ALTERNATIVA: OUT
? Exclusico de C#, puede no existir en otros lenguajes
* Cuando importa el valor de salida, pero realmente no necesitamos que entre ningun valor, sino solo queremos sacar resultados.
*/

using System;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
/*
class Parametros1
{
    static void Main()
    {
        int n = 5;
        Duplicar(ref n);
        Console.WriteLine(n); 
    }

    static void Duplicar(ref int x)
    {
        x = x * 2;
        Console.WriteLine(x);
    }
}
*/
/*
class Parametrso2
{
    static void Main()
    {
        char letra1, letra2;
        ObtenerPrimeraYUltima("Hoala", out letra1,  out letra2);
        Console.WriteLine(letra1 +" "+ letra2);
    }
    static void ObtenerPrimeraYUltima(string texto, out char primera, out char ultima)
    {
        primera = texto[0];
        ultima = texto[texto.Length-1];
    }
}
*/

//TODO: EJERCICIO PROPUESTO
//? Crea un programa que, usando parametros "ref", reciva un array de enteros y devuleva su maximo y minimo.

class EjercicioPropuesto
{
    static void Main()
    {
        int[] numeros = {3, 5, 7, 2, 8, -1, 4, 10, 12};
        int maximo = 0;
        int minimo = 0;

        ObtenerMaximoMinimo(numeros, ref maximo, ref minimo);

        Console.WriteLine($"El valor maximo es: {maximo}");
        Console.WriteLine($"El valor minimo es: {minimo}");
    }

    static void ObtenerMaximoMinimo(int[] array, ref int maximo, ref int minimo)
    {
        maximo = array[0];
        minimo = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maximo)
                maximo = array[i];

            if (array[i] < minimo)
                minimo = array[i]; 
        }
    }
}