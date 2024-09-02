//! 018 - DIAGRAMAS DE FLUJO Y DE NASSI-SHNEIDERMAN

// online flowchart

//? Los diagramas de flujo no son capaces de representar todo lo que permite un lenguaje moderno
//* El proceso es muy lento... a veces, bastante mas que teclear el programa correspondiente

//* * los diagramas son mas usados mientras las cajas de nassi shneiderman son poco legibles por lo que no son tan usadas

/*
TODO: EJERCICIOS PROPUESTOS

* - Crea un diagrama de flujo para un programa en el que el usuario tenga un numero ilimitado de intentos para advinar un numero (prefijado) del 1 al 100. tras cada intento se le dira si ha acertado, se ha quedado corto o se ha pasado.

* - Crea un diagrama de Nassi-Shneiderman para ese mismo programa.
*/


int option;
int prefijado = 5;

Console.Write("Advina el numero: ");
option = Convert.ToInt32(Console.ReadLine());

while (option > 0)
{
    int intentos = 0;
    int sum;
    if (option == prefijado)
    {
        Console.WriteLine("ACERTADO");
        Console.WriteLine("Tu numero de intentos es: {0}", intentos);
        break;
    }
    else if (option > prefijado)
    {
        Console.WriteLine("Te haz pasado");
        intentos++;
        Console.WriteLine("Tu numero de intentos es: {0}", intentos);
        
    }
    else if (option < prefijado)
    {
        Console.WriteLine("Te haz quedado corto");
        intentos += intentos++;
        Console.WriteLine("Tu numero de intentos es: {0}", intentos);
    }
    else
    {
        Console.WriteLine("Error de respuesta");
        intentos += intentos++;
        Console.WriteLine("Tu numero de intentos es: {0}", intentos);
    }
    Console.Write("Advina el numero: ");
    option = Convert.ToInt32(Console.ReadLine());
}

// Console.WriteLine("Tu numero es: {0}", option);