//! 055 - CLASES 1: CONTACTO CON LA POO

/* POO
 * "Programacion orientada a objetos" (OOP)
 * Diferente forma de plantear grandes proyectos
 * Hasta ahora: variables, estructuras repetitivas y funciones
 * Ahora: "objetos" que cooperan y se "envian mensajes" entre ellos
*/

/* SI NO USAMOS POO
 * lo que haciamo hasta ahora:
 * int xJugador, xEnemigo;
 
 Y, en otra parte del programa:
 * void DibujarJugador() {...}
 * void DibujarEnemigo() {...}
*/ 

/* USANDO POO (1)
 * Apariencia de una clase:
 * public class ElementoGraficos
 * {
 *  int x, y;
 *  public void Dibujar() {//No "static"}
 *  ...
 * }
*/ 

/* USANDO POO (2)
 * "Atributos" o "variables miembro": int x, y;
 * "Metodos" o "funciones miembro": void Dibujar(). En general, no seran "static", Pronto veremos el motivo.
 * Todo ello forma parte del mismo bloque: 
 *  ENCAPSULAMIENTO
*/ 

/* USANDO POO (3)
 * Uso: similar a los structs, pero sera necesario usar "new" y normalmente contendra funciones:
 * ElmentoGrafico enem1 = new ElementoGrafico();
 * enem1.x = 20; enem1.y = 100;
 * enem1.Dibujar();
 */

// EJERCICIO RESUELTO
// ? Crea un clase llamada "Titulo".
// ? Sus atributos (publicos) seran el texto y las coordenadas x e y.
// ? Tendra un metodo llamado "Mostrar", que mostrara su texto en la pantalla, en las coordenadas indicadas como parametro.
// ? Crea una clase "PruebaDeTitulo" con un "Main" para probarlo


using System;
/*    
class Titulo
{
   public int X, Y;
   public string Texto;

   public void Mostrar()
   {
     Console.SetCursorPosition(X, Y);
     Console.WriteLine(Texto);
   }
}

class PruebaDeTitulo
{
  static void Main()
  {
    Titulo t = new Titulo();
    t.X = 30;
    t.Y = 10;
    t.Texto = "Hola";
    t.Mostrar();
  }
}
*/

// TODO: EJERCICIO PROPUESTO
// ? Crea una clase llamada "Persona".
// ? Sus atributos (publicos) seran el nombre y el anio de nacimiento.
// ? Tendra un metodo llamado "Saludar", que mostrara en tantalla el texto "Hola, soy" seguido de su nombre.
// ? Crea una clase "PruebaDePersona" con un "Main" para probarlo

class Persona
{
  public string Nombre;
  public int AnioNacimiento;

  public void Saludar()
  {
    Console.WriteLine("Hola, soy " + Nombre);
  }
}

class PruebaDePersona
{
  static void Main()
  {
    Persona p = new Persona();
    p.Nombre = "Juan";
    p.AnioNacimiento = 20;
    p.Saludar();
  }
}