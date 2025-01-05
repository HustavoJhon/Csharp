//! 056 - CLASES 2: OCULTACION DE DETALLES

/* OCULTACION DE DETALLES
* Se recomienda no permitir el acceso directo a los atributos: OCULTACION DE DATOS.

* Los datos seran "privados" ("private").
* Funcion auxiliar publica para leer el valor:
*   int GetX()
* Y otra para cambiar el valor:
*   void SetX(int x)
*/

using System;
using System.Runtime.InteropServices;

/*
class Titulo
{
    private int x, y;
    private string texto;

    public int GetX() { return x; }
    public int GetY() { return y; }
    public string GetTexto() { return texto; }

    public void SetX(int nuevoX) { x = nuevoX; }
    public void SetY(int nuevoY) { y = nuevoY; }

    public void SetTexto(string nuevoTexto)
    {
        texto = nuevoTexto;
    }
    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(texto);
    }
}

class PruebaDeTitulo
{
    static void Main()
    {
        Titulo t = new Titulo();
        t.SetX(30);
        t.SetY(10);
        t.SetTexto("Hola");
        t.Mostrar();

        int x = t.GetX();
    }
}
*/

// TODO: EJERCICIO PROPUESTO
// ? Crea una version de la clase "Persona".
// ? Sus atributos seran privados y tendran getters y setters.
// ? Cambia la clase, la prueba y "Main" segun sea necesario.

class Persona
{
    private string nombre;
    private string apellidos;

    public string GetNombre() { return nombre; }
    public string GetApellidos() { return apellidos; }

    public void SetNombre(string nuevoNombre) { nombre = nuevoNombre; }
    public void SetApellidos(string nuevoApellidos) { apellidos = nuevoApellidos; }

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + nombre + " " + apellidos);
    }
}

class SaludarPersona
{
    static void Main()
    {
        Persona persona1 = new Persona();
        persona1.SetNombre("Cristian");
        persona1.SetApellidos("Cabanes");

        persona1.Saludar();
    }
}