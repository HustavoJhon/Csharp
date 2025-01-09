//! 007 - FORMATO LIBRE, COMENTARIOS

// csharp nos permite tener todo el codigo sin identacion aunque son malas practicas como tener todo en una sola linea pero es perfectamente valido ya que su funcionamiento va ser el mismo
// Pero la idea es siempre tenerlo ordenado para que sea facil leer como con las lineas en blanco separando en bloques las variables - entradas de datos - salidas de datos 

string? name; Console.Write("Como te llamas: "); name = Console.ReadLine(); Console.WriteLine("Hola " + name);

// Comentarios son para describir bloques de codigo pero no deben ser evidentes
// Comentar al principio de cada archivo como:
/*
Programa para saludar
Por Gustavo Jhon
*/

//TODO: EJERCICIO PROPUESTO
//? Haz un programa que pida al usuario una cantidad de metros y la convierta a millas (1 milla terrestre = 1909,344 metros). debe incluir dos comentarios de una linea al princiio del programa: una que recuerde que hace el programa y otro con tu nombre.

/* 
PROGRAMA PARA CONVERTIR DE MILLAS A METROS
POR GUSTAVO JHON
*/

int metros; 
double millas = 1609.344;
double resultado;

Console.Write("Ingrese cuantos metros quiere convertir: ");
metros = Convert.ToInt32( Console.ReadLine() );

resultado = metros / millas; //formular para convertir de metros a millas

Console.WriteLine("El resultado es: " + resultado);