//! TIPOS DE VARIABLES - CLASE #3

//TODO: C# es un lenguaje fuertemente tipado. Todas las varialbes y constantes tiene un tipo, al igual que todas las expresiones que se evaluan como un valor.

//? Tipo INT
//* Tipo de dato numerico (entero)
int n1 = 5; 
int n2 = 4;
int suma = n1 + n2;
Console.WriteLine("\nSuma con el tipo de dato INT: " + suma);

//? Tipo FLOAT
//* Tipo de dato numerico (decimal de 7 digitos)
float f1 = 5.5f;
float f2 = 4.4f;
float suma1 = f1 + f2;
Console.WriteLine("\nSuma con el tipo de dato FLOAT: " + suma1);

//? Tipo DOUBLE
//* Tipo de dato numerico (decimal de 15 digitos)
double d1 = 5.5;
double d2 = 4.4;
double suma2 = d1 + d2;
Console.WriteLine("\nSuma con el tipo de dato DOUBLE: " + suma2);

//? Tipo STRING
//* Tipo de dato de cadena de caracteres
string s1 = "Hola";
string s2 = "Mundo";
string s3 = s1 + " " + s2;
Console.WriteLine("\nConcatenacion con el tipo de dato STRING: " + s3);

//? Tipo CHAR
//* Tipo de dato de un caracter
char c1 = 'a';
char c2 = 'b';
char c3 = (char) (c1 + c2);
Console.WriteLine("\nConcatenacion con el tipo de dato CHAR: " + c3);

//? Tipo BOOLEAN
//* Tipo de dato de verdadero o falso
bool b1 = true;
bool b2 = false;
bool b3 = b1 && b2;
Console.WriteLine("\nOperador &&: " + b3);
bool b4 = b1 || b2;
Console.WriteLine("Operador ||: " + b4);
bool b5 = !b1;
Console.WriteLine("Operador !: " + b5);