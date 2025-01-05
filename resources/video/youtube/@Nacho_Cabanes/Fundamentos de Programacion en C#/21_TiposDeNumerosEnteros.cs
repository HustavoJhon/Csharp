//! 021 - Tipos de numeros enteros

//? Solo existe "INT"?

//** No, podremos manejar tambien numeros con decimales, texto, y datos compuestos de mayor complejidad

//** Incluso entre los numeros enteros, existen mas alternativas que "int"

//? "TAMANO DE LA INFORMACION

// * - Byte -> q byte = 1 caracter (simplificado)
// En alfabeo mas complejo que el ingles, un simbolo puede ocupar mas de un byte
// * - Kilobyte -> 1 Kilobyte = aprox. 1000 bytes
// 1 kilobyte = 1024 bytes
// no sera 1000 por que es un divisor de 2 como 24 o nc
// * - Megabyte
// * - Terabyte

//? Y Tambien el BIT
//* 1 bit = 0 o 1

//? "Convert.To32" por que un "int" ocupa 4 bytes (=32 bits)
//* - int: entero "normal"
//* - long: Mayor que "int"
//* - short: Menor que "int"
//* - byte: Todavia mas pequeno

//TODO: TIPOS DE DATOS "ENTEROS" (2)
//? En "sbyte", "s" = "signed"
//? En "unshort", "u" = "unsigned"
//* Nombre | Tamano(bytes) | Rango
// sbyte | 1 | -128 a 127
// byte | 1 | 0 a 255
// short | 2 | -32768 a 32767
// ushort | 2 | 0 a 65535 
//TODO: TIPOS DE DATOS "ENTEROS" (3)
// int | 4 | 21447483648 a 21447483648
// uint | 4 | 0 a 4294967295
// long | 8 | -9e18 a 9e18
// ulong | 8 | 0 a 18e18


//! CONVERTIR TEXTO A ENTERO

// - No solo existe ToInt32:
    // - Convert.ToByte (sin signo) y Convert.ToSByte (consigno)
    // - ToInt16 (con signo) y ToUint16 (sin signo)
    // - ToInt64 (con signo) y ToUInt64 (sin signo)


using System;

/*
class Program
{
    static void Main()
    {
        byte estatura;

        Console.WriteLine("Ingrese su estatura");
        estatura = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Su estatura es: " + estatura);
        Console.WriteLine("Tu estatura en metros es: " + estatura/100.0); 
    }
}
*/

//TODO: EJERCICIO PROPUESTO
// Pide al usuario su ano de nacimiento, su edad, y la poblacion de su pais, usando tipos de datos optimizados para ello.
using System;

class Program
{
    static void Main()
    {
        // Pedir el año de nacimiento (short es suficiente para manejar años)
        Console.Write("Ingrese su año de nacimiento: ");
        short anioNacimiento = short.Parse(Console.ReadLine());

        // Pedir la edad (byte es suficiente para manejar edades hasta 255)
        Console.Write("Ingrese su edad: ");
        byte edad = byte.Parse(Console.ReadLine());

        // Pedir la población de su país (usamos long porque la población puede ser un número muy grande)
        Console.Write("Ingrese la población de su país: ");
        long poblacionPais = long.Parse(Console.ReadLine());

        // Mostrar los datos ingresados
        Console.WriteLine($"\nAño de nacimiento: {anioNacimiento}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Población del país: {poblacionPais}");
    }
}

