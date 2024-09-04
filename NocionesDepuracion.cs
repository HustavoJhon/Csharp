//! 020 -  Nociones de Depuracion

//TODO: Alternativa mas "profesional": menu Depurar, Paso a paso po instr.

//TODO: "Depurar" ayudara a encontrar fallos cucando un programa no se comporte de la forma esperada

//** Agregar puntos de interrupcion (Breakpoints)
// Desde la terminal se puede depurar de manera basica con herramientas como 'dotnet-dimp' y 'dotnet-trace'

//? En "Inspeccion" podemos escribir cualquier expression
//? Paso a paso por procedimientos "funciones" (mas adelante)
//? Podemos agregar "punto de interrupcion" para que el programa se detenga al llenar a un punto
//? y con f11 en visual studio avanzaria para ver los procesos de cada linea

unsing System;

class Depuracion
{
    static void maint()
    {
        int a, b, c;

        a = 5;
        a = a * 7 + 9 / 3;
        b = a - 2;
        c = b * 2;
        Console.WriteLine("a vale {0}", a); //? Forma "pobre" -> adicionales
        //* Sera cada vez menos practico a medida que el programa crece
        if (a - 15 > 20)
        {
            b = b  - 5;
        }
        c = b - a * 2;

        Console.WriteLine(c);
    }
}