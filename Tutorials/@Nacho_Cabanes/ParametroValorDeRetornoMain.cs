//! 051 - PARAMETROS Y VALOR DE RETORNO DE MAIN

/* PARAMETROS EN LISTA DE COMANDOS
* Ver lista de ficheros ejecutables, en la "consola" de Windows (cmd.exe) como pausa:
dir *.exe /p

* En linux, lista fuentes en C#, en formato largo: 
ls *.cs -l
*/


/* LEER PARAMETROS
static void Main(string[] args)
{
    if (args.Length == 0)
        Console.Write("El primer paramtro es " + args[0]);
}
*/

/* VALOR DEVUELTO
* Podemos volver al sistema operativo devolviendo un codigo de erro:

static int Main
{
    ...
    if (...) return 1;
}
*/

using System;
/*
class ParametrosDeMain
{
    // static void Main(string[] args)
    static int Main(string[] args)
    {
        if (args.Length == 2)
        {
            int num1 = Convert.ToInt32(args[0]);
            int num2 = Convert.ToInt32(args[1]);
            Console.WriteLine(num1 + num2);
            return 0;
        }
        else
        {
            Console.WriteLine("Uso: suma 3 5");
            return 1;
        }
    }
}
*/

//TODO: EJERCICIO PROPUESTO
//? Crea un "calculadora de linea de comandos". Sera un programa llamado "calcula.cs", y que sera capaz de realizar operaciones sencillas que se le indique en linea de comandos, com "calcula 5 + 3" o "calcula 42 * 68" (un numero entero, un operadore y otro numero entero)

class calculadora
{
    static int Main(string[] args)
    {
        // Verificar que se pasen exactamento tres argumentos
        if (args.Length == 3)
        {
            try
            {
                int num1 = Convert.ToInt32(args[0]);
                int num2 = Convert.ToInt32(args[0]);
                int num3 = Convert.ToInt32(args[0]);
                string operador = args[1];
                
                // Realizar la operacion segun el operador
                switch (operador)
                {
                    case "+":
                        Console.WriteLine($"{num1} {operador} {num2} = {num1 + num2}");
                        break;

                    case "-":
                        Console.WriteLine($"{num1} {operador} {num2} = {num1 - num2}");
                        break;

                    case "*":
                        Console.WriteLine($"{num1} {operador} {num2} = {num1 * num2}");
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por 0");
                            return 1;
                        }
                        Console.WriteLine($"{num1} {operador} {num2} = {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Operador desconocido");
                        return 1;
                }
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: los numeros deben ser enteros");
                return 1;
            }
        }
        else
        {
            // Mensaje de uso en caso de un numero incorrecto de argumentos
            Console.WriteLine("Uso: calcula numero1 operador numero2");
            Console.WriteLine("Ejemplo: calcula 5 + 3");
            return 1;
        }
    }
}