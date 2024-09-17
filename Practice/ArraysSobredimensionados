//! 035 - ARRAYS SOBREDIMENSIONADOS

/* AGREGAR AL FINAL
* Para poder agregar un dato al final de los ya existentes: el array no debe estar completamente lleno, y necesitamos un contador de posiciones ocupadas ("array sobredimensionado"):
if (cantidad < capacidad)
{
    dato[cantidad] = 6;
    cantidad++;
}
*/

/* INSERTAR
* Para insertar un dato en una cierta posicion, habra que desplazar "hacia la derecha" los siguientes (empexando desde el final) y actualizando el contador:

for (i=cantidad; i>posicionInsertar; i--)
{
    datos[i] = datos[i-1];
}
datos[posicionInsertar] = 30;
cantidad++;
*/

/* BORRAR
* Para borrar un dato, los siguientes deberan desplazarse "hacia la izquierda" para que no queden huecos, y luego actualizar el contador:

int posicionBorrar = 1;
for (int i = posicionBorrar; i < cantidad; i++)
{
    datos[i] = datos[i + 1];
}
cantidad--;
*/

using System;

class ArraySobredimensionado
{
    static void Main()
    {
        /*
        string[] frases = new string[1000];
        string opcion;
        int cantidad = 0;

        do
        {
            Console.WriteLine("Escoge una opcion: ");
            Console.WriteLine("1. Agregar frase");
            Console.WriteLine("2. Mostrar todas las frases");
            Console.WriteLine("3. Insertar");
            Console.WriteLine("4. Borrar");
            Console.WriteLine("0. Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Dime un dato: ");
                    string frase = Console.ReadLine();
                    frases[cantidad] = frase;
                    cantidad++;
                    break;

                case "2":
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine(frases[i]);
                    }
                    break;

                case "3":
                    int posicionInserta = 2;
                    for (int i = cantidad;i > posicionInserta ; i--)
                    {
                        frases[i] = frases[i - 1];
                    }
                    frases[posicionInserta] = "Insertado";
                    cantidad++;
                    break;

                case "4":
                    int posicionBorra = 1;
                    for (int i = posicionBorra; i < cantidad; i++)
                    {
                        frases[i] = frases[i + 1];
                    }
                    cantidad--;
                    break;
            }
        }
        while (opcion != "0");
        */

        // TODO: EJERCICIO PROPUESTO
        //? Crea un programa que permita al usuario agregar a un array numeros reales (de doble precision), tanto al final de los datos como en una posicion intermedia, borrar un dato de cualquier posicion o ver el contenido del array.
        double[] numeros = new double[1000];
        string opcion;
        int cantidad = 0;

        do
        {
            // Mostrar opciones al usuario
            Console.WriteLine("\nEscoge una opción:");
            Console.WriteLine("1. Agregar número al final");
            Console.WriteLine("2. Insertar número en una posición específica");
            Console.WriteLine("3. Borrar número de una posición específica");
            Console.WriteLine("4. Mostrar todos los números");
            Console.WriteLine("0. Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": // Agregar número al final
                    Console.Write("Introduce un número real de doble precisión: ");
                    double numero = Convert.ToDouble(Console.ReadLine());
                    numeros[cantidad] = numero;
                    cantidad++;
                    Console.WriteLine("Número agregado al final.");
                    break;

                case "2": // Insertar número en una posición específica
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay números en la lista. Debes agregar primero un número.");
                    }
                    else
                    {
                        Console.Write("Introduce el número real a insertar: ");
                        double numeroInsertado = Convert.ToDouble(Console.ReadLine());
                        Console.Write($"Introduce la posición (0 a {cantidad}): ");
                        int posicionInserta = Convert.ToInt32(Console.ReadLine());

                        if (posicionInserta >= 0 && posicionInserta <= cantidad)
                        {
                            for (int i = cantidad; i > posicionInserta; i--)
                            {
                                numeros[i] = numeros[i - 1]; // Desplazar los números hacia la derecha
                            }
                            numeros[posicionInserta] = numeroInsertado; // Insertar el número
                            cantidad++;
                            Console.WriteLine("Número insertado.");
                        }
                        else
                        {
                            Console.WriteLine("Posición inválida.");
                        }
                    }
                    break;

                case "3": // Borrar número de una posición específica
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay números para borrar.");
                    }
                    else
                    {
                        Console.Write($"Introduce la posición a borrar (0 a {cantidad - 1}): ");
                        int posicionBorra = Convert.ToInt32(Console.ReadLine());

                        if (posicionBorra >= 0 && posicionBorra < cantidad)
                        {
                            for (int i = posicionBorra; i < cantidad - 1; i++)
                            {
                                numeros[i] = numeros[i + 1]; // Desplazar los números hacia la izquierda
                            }
                            cantidad--;
                            Console.WriteLine("Número borrado.");
                        }
                        else
                        {
                            Console.WriteLine("Posición inválida.");
                        }
                    }
                    break;

                case "4": // Mostrar todos los números
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay números en el array.");
                    }
                    else
                    {
                        Console.WriteLine("Contenido del array:");
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine($"{i}: {numeros[i]}");
                        }
                    }
                    break;

                case "0": // Salir del programa
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != "0");
    }
}

