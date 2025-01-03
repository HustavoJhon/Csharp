// VARIABLES
// Las variables son una parte fundamental en la programacion, imagina que una variable es una caja en la cual puedes almacenar algo, eso que almacenas podrias utilizarlo mas adelante para realizar algunas operaciones, las variables cumplen ese objetivo, el poder guardar un valor.
// Una definicion formal de variables es: un contenedor de informacion que puedes utilizar  para almacenar un valor en memoria.
// En C# podemos crear varibles par almacenar informacion, esta informacion seran valores, como numeros o cadenas de texto, en si, las variables sirven para guardar informacion que sera utilizada en nuestros programas.

// creamo una variable que solo puede guardar numeros
int number = 88;
// Para imprimir en pantalla el resultado de una variable
Console.WriteLine(number);

// Y procedermeos a ejecutar nuestro proyecto para que obtengamos el siguiente resultado:
// 88
//
// ¿Qué es lo que ha pasado? Lo que pasó es que creamos una variable la cual solo puede almacenar números enteros, siendo un número entero, un número que no puede tener decimales, es decir: 1, 4, 56, 10; pero no un número 13.4 o 1.2321.
// Una variable en C# debe contener el tipo con el cual vamos a trabajar, en este caso el tipo es un número entero, y la palabra reservada para establecer este tipo es int, seguido del nombre que deseamos para nuestra variable, en este ejemplo la llamamosnumber, cuando utilizamos la palabra que hemos escrito number, hacemos referencia a ella, como lo hicimos en Console.WriteLine(number). Más adelante comprenderás que significa Console.WriteLine, así que no te preocupes por ahora con ello, solo velo como un funcionamiento que nos ayuda a imprimir resultados en pantalla.
// También es importante notar que en C# es obligatorio poner punto y coma (;) al final de cada línea de código.
//El texto que está posterior a las dos diagonales // algo aquí) es un comentario, este comentario será ignorado al momento de ejecutar nuestro código, pero son útiles para cuando programamos pongamos recordatorios de que es lo que hace nuestro código.
// Como podemos ver una variable puede guardar información, pero debemos establecer el tipo de información que va a guardar, por ejemplo, si deseamos guardar una cadena de texto tendríamos que hacer lo siguiente:
string text = "Hola soy Hector de Leon";
Console.WriteLine(text);
// y tendriamos como resultado
// Hola soy Hector de Leon
// Si lo notaste, en este segundo ejemplo, para guardar una cadena de texto en una variable hemos escrito la palabra string seguida del nombre de nuestra variable la cual llamamos name, pero el valor que hemos puesto lo posimos entre comillas, es decir "Hola soy Hector de Leon"
// Cuando trabajamos con cadenas de texto, en la mayoria de lenguajes de programacion, va ser comun poner el valor entre comillas.
// El nombramiento de las variables debe seguir ciertas reglas (dependiendo el lenguaje de programacion), en C# la regla es: que siempre debe iniciar por una letra o un guion bajo (_), posteriormente puede tener mas letras, guiones bajos (_) y numeros, y no puedes dejar espacio en blanco en su nombre.
// Como consejo en nombramiento de variables es que el nombre te indique cual es la funcion o el objetivo de la variable, de esta forma y como extra escribelas en ingles, ya que sera comun ver mas codigo escrito en ingles que en espanol.
// Ejemplos de variables correctamente nombradas en C#:
// - name
// - age
// - error500
// - _some
// Como conclusion, las variables es una funcionalidad que tienen los lenguajes de programacion para poder almacenar informacion con la cual trabajaremos, esta informacion debe tener un tipo, el cual definira que se puede almacenar, si definimos que sera un numero entero no podemos guardar una cadena de texto, y viserversa.
