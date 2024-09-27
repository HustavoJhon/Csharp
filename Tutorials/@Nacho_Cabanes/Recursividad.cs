//! 050 - RECURSIVIDAD

/*
? En ocaciones, el comportamiento de una funcion se puede explicar a partir de casos mas sencillos de la misma funcion

* Factorial de 6: 6! = 6*5*4*3*2*1 = 720
* Factorial de 5: 5! = 5*4*3*2*1 = 120
* Luego 6! = 6 * 5
*/

/* COMO SE PROGRAMA ESO?
* Una funcion que se llama a si misma:

factorial(n) = n * factorial(n-1);

? debe existir un caso base, que permita terminar las llamadas recursivas: factorial(1) = 1;
*/

/* Y EN C#

static in Factorial(int num)
{
    if (num == 1)
        return 1;
    return num * Factorial(num - 1);
}
*/

/* SECUENCIAS DE LLAMADAS (1)
4! = 4 * 3 !
?    3! esta pendiente de calcular, se guarda 4
3! = 3 * 2 !
?    2! esta pendiente de calcular, se guarda 3
2! = 2 * 1 !
?    1! esta pendiente de calcular, se guarda 2
1! = 1
*/

/* SECUENCIAS DE LLAMADAS (2)
* "Sustitucion regresiva":
1! = 1
2! = 2 * 1! = 2 * 1 = 2
3! = 3 * 2! = 3 * 2 = 6
4! = 4 * 3! = 4 * 6 = 24
5! = 5 * 4! = 5 * 24 = 120
6! = 6 * 5! = 6 * 120 = 720
*/

/* ES EFICIENTE?
* Los ejemplos que hemos visto se podrian planetear tambien con un "for" (de forma "iterativa")

* Por lo general, una funcion recursiva sera mas lenta que un "for"

* Por lo general, una funcion recursiva gastara mas memoria que un "for"

? Pero... hat problemas muy concretos que no se pueden resolver con un "for" y si con "recursividad"
*/

using System;

/*
class Recursividad1
{
    //? EJEMPLO 1 - FACTORIAL
    static int Factorial(int num)
    {
        if (num == 1)
            return 1;
        return num * Factorial(num - 1);
    }

    //? EJEMPLO 2 - POTENCIA
    static int Potencia(int a, int b)
    {
        // Caso base
        if (b == 0)
            return 1;

        // Caso general
        return a * Potencia(a, b - 1); // 2^5 = 2^4 * 2
    }

    //? EJEMPLO 3 - BUSCAR EN UNA CADENA
    static bool Contiene(string cadena, char caracter)
    {
        // Caso base
        if (cadena.Length == 0)
            return false;

        // Caso general
        if (cadena[0] == caracter)
            return true;
        else
            return Contiene(cadena.Substring(1), caracter);
    }

    //? EJEMPLO 4 - INVERSAR UNA CADENA
    static string Invertir(string texto)
    {
        // Caso base
        if (texto.Length <= 1)
            return texto;


        // Caso general
        return Invertir(texto.Substring(1)) + texto[0];
    }

    static void Main()
    {
        Console.WriteLine("Ejemplo 1: Factorial");
        Console.WriteLine("Factorial de 6");
        Console.WriteLine(Factorial(6));

        Console.WriteLine("Ejemplo 2: Potencia");
        Console.WriteLine("Potencia de 2 elevado a 3");
        Console.WriteLine(Potencia(2, 3));

        Console.WriteLine("Ejemplo 3: Contiene");
        Console.WriteLine("Contiene 'Nacho' en 'Nacho Cabanes'");
        Console.WriteLine(Contiene("Nacho Cabanes", 'N'));

        Console.WriteLine("Ejemplo 4: Inversa");
        Console.WriteLine("Inversa de 'Nacho'");
        Console.WriteLine(Invertir("Nacho"));
    }
}
*/

// TODO: EJERCICIO PROPUESTO (1)
//* Crear una funcion recursiva que permita calcular el producto de dos numeros a partir de sumas, Piensa caul podria ser el caso base (por ejemplo, si el segundo numero es 0) y como te acercarias a el desde el caso general (por ejemplo, si sabes cuantos vale n*1004, podrias calcualar cuanto vale n*1005?)

// TODO: EJERCICIO PROPUESTO (2)
//* Crea una funcion  recursiva que compruebe si una cadena es palindroma (se lee igual de izquierda a derecha.) Piensa cual seria el caso base (por ejemplo, longitud 1 o 0) y como te acercarias a el desde un caso general.

// TODO: EJERCICIO PROPUESTO (3)
//* En la sucesion de Fibonacci, se considera que el primer numero es F(0) = 0 y el segundo es F(1) = 1, y cada termino posterios es la suam de los dos que le preceden, de modo que la serie es 0, 1, 1, 2, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233... Crea una funcion recursiva que permita calcular el valor de cualquier termino de la sucesion de Fibonacci, y usala en un "Main" que muestre los 20 primeros.


using System;

class Recursividad2
{
    // TODO: EJERCICIO PROPUESTO (1) - Producto mediante sumas
    static int Producto(int a, int b)
    {
        // Caso base
        if (b == 0)
            return 0;

        // Caso general
        return a + Producto(a, b - 1);
    }

    // TODO: EJERCICIO PROPUESTO (2) - Comprobar si una cadena es palíndroma
    static bool EsPalindroma(string cadena)
    {
        // Eliminar espacios y pasar a minúsculas para comparar correctamente
        cadena = cadena.Replace(" ", "").ToLower();

        // Caso base
        if (cadena.Length <= 1)
            return true;

        // Caso general
        if (cadena[0] == cadena[cadena.Length - 1])
            return EsPalindroma(cadena.Substring(1, cadena.Length - 2));
        else
            return false;
    }

    // TODO: EJERCICIO PROPUESTO (3) - Sucesión de Fibonacci
    static int Fibonacci(int n)
    {
        // Casos base
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        // Caso general
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        // Ejercicio Propuesto (1): Producto mediante sumas
        Console.WriteLine("Ejercicio Propuesto (1): Producto mediante sumas");
        int a = 7;
        int b = 5;
        Console.WriteLine($"Producto de {a} y {b} (mediante sumas): {Producto(a, b)}");

        // Ejercicio Propuesto (2): Comprobar si una cadena es palíndroma
        Console.WriteLine("\nEjercicio Propuesto (2): Comprobar si una cadena es palíndroma");
        string cadena = "anita lava la tina";
        Console.WriteLine($"¿'{cadena}' es palíndroma?: {EsPalindroma(cadena)}");

        // Ejercicio Propuesto (3): Sucesión de Fibonacci
        Console.WriteLine("\nEjercicio Propuesto (3): Sucesión de Fibonacci");
        Console.WriteLine("Primeros 20 números de la sucesión de Fibonacci:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}
