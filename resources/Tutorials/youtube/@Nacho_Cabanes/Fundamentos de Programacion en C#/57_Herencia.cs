//! 057 - CLASES 3: HERENCIA

/* HERENCIA
* Se pueden defini nievas "subclases" a partir de clases "mas genericas": Herencia

class Enemigo: ElementoGrafico{...}
* Un "Enemigo" tendras una "x" y una "y", porque es un tipo de EnemigoGrafico
* Podemos "Dibujar" un "Enemigo", porque es un tipo de ElementoGrafico
*/
using System;
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
    public void SetTexto(string nuevoTexto) { texto = nuevoTexto; }

    public void Mostrar()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(GetTexto());
    }
}
//----------------
class TituloSubrayado : Titulo
{
    public new void Mostrar()
    {
        Console.SetCursorPosition(GetX(), GetY());
        Console.WriteLine(GetTexto());

        Console.SetCursorPosition(GetX(), GetY() + 1);
        Console.WriteLine(new string ('-', GetTexto().Length));
    }
    
}
//----------------
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

        TituloSubrayado t2 = new TituloSubrayado();
        t2.SetX(50);
        t2.SetY(13);
        t2.SetTexto("Que tal?");
        t2.Mostrar();
    }
}
*/

// TODO: EJERCICIO PROPUESTO
// ? Crea una clase "PersonaInglesa", que herede de Persona.
// ? No hara falta reescribir getters y setters, porque se heredan. Si redefiniras el metodo "Saludar", para que escriba "Hi, I'm" seguido de su nombre

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

class PersonaInglesa : Persona
{
    public new void Saludar()
    {
        Console.WriteLine("Hi, I'm " + GetNombre() + " " + GetApellidos());
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

        PersonaInglesa persona2 = new PersonaInglesa();
        persona2.SetNombre("Brian");
        persona2.SetApellidos("Molina");
        persona2.Saludar();

    }
}