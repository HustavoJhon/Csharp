//! 054 - PARAMETROS CON VALORES POR DEFECTO Y CON NOMBRE

/* PARAMETROS CON "VALORES POR DEFECTO"
* En pocos lenguajes. Para algun parametro (tipicamente del final), se puede indicar un valor por defecto.

* static string Linea(int veces, char letra='*')...

* Console.WriteLine(Linea(10, '-'));
* Console.WriteLine(Linea(12));
*/

/* PARAMTROS CON "NOMBRE"
* Algunos lenguajes permiten llamar a una funcion indicando los parametros en orden distinto al de definicion (precedidos por su nombre)

* static string Linea(int veces, char letra='*')...

* Console.WriteLine(Linea(letra: '=', veces: 8));
*/

using System;

class ParametrosDefectoNombre
{
    static void Dibujarlinea(int repeticiones, char letra='-')
    {
        Console.WriteLine(new string(letra, repeticiones));
    }
    static void Main()
    {
        Dibujarlinea(20, '=');
        Dibujarlinea(25);

        Dibujarlinea(letra:'*', repeticiones:30);
    }
}

//TODO: EJERCICIOS PROPUESTOS
//* Crea una funcion "DibujarRecuadro", que muestre en pantalla un recuadro de un cierto ancho, alto y caracter de relleno. El caracter sera opcional, y se usara "almohadillas" si no se indica otro. El alto tambien sera opcional, con valor por defecto de 3. Pruebalo desde Main.

//* En un segundo programa, usa "DibujarRecuadro" llamando con los parametros en orden inverso (primero el caracter, luego el alto y finalmente el ancho).