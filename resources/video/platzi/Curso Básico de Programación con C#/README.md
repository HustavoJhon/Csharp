# Curso Básico de Programación con C#

> Básico

- Publicado el 09 de enero de 2023
- 4 Horas de contenido
- 8 Horas de práctica

**Conocimientos previos**

- Programación Básica
- Pensamiento Lógico y Algoritmos

**Software para este curso**

- Visual Studio Community

C# es uno de los lenguajes de programación más utilizados para desarrollo web y videojuegos. Da tus primeros pasos en C#, junto al profesor Ricardo Celis, construyendo juegos virtuales mientras aprendes las siguientes habilidades:

1. Introducción a la programación con C#
2. Primeros pasos con C#
3. Bucles y estructuras de control en C#

**Más sobre el curso**

Este es el primer curso de la saga de C#. En este curso aprenderás lo más básico que necesitas saber de este lenguaje, desde qué son las variables hasta los diferentes tipos de datos que existen. En futuras entregas estaremos aprendiendo sobre cómo funcionan las estructuras de control en C# e incluso Programación Orientada a Objetos.

## ¿Por que aprender C#?
Aprender C# es importante debido a su popularidad, versatilidad, facilidad de aprendizaje, y su demanda en el mercado laboral.

1. Es un lenguaje de programación popular y versátil que se utiliza en una variedad de aplicaciones, incluyendo desarrollo de juegos, aplicaciones de escritorio y móviles, y desarrollo web.
2. Es un lenguaje de programación de Microsoft, lo que significa que es compatible con una variedad de herramientas y tecnologías de Microsoft, como Visual Studio y .NET Framework.
3. Es un lenguaje de programación moderno que tiene una sintaxis fácil de aprender y ofrece características avanzadas, como programación orientada a objetos y manejo automático de memoria.

## ¿Que son los algoritmos?

Un algoritmo es un conjunto de instrucciones que se resuelve paso a paso y sin ambiguedades. Tendremos una serie de objetos o elementos en nuestros programas y tambien tendremos una logica una serie de pasos a seguir para que el software se comporte de la forma esperada. Esta logica o estos pasos a seguir es lo que se conoce como algoritmos.

Se denomina algoritmo a un grupo finito de operaciones organizadas de manera lógica y ordenada que permite solucionar un determinado problema. Se trata de una serie de instrucciones o reglas establecidas que, por medio de una sucesión de pasos, permiten arribar a un resultado o solución.

++Propiedades de los algoritmos++

Existen ciertas propiedades que alcanzan a todos los algoritmos, con excepción de los denominados algoritmos paralelos: el tiempo secuencial (los algoritmos funcionan paso a paso), el estado abstracto (cada algoritmo es independiente de su implementación) y la exploración acotada (la transición entre estados queda determinada por una descripción finita y fija).

Cabe mencionar que los algoritmos son muy importantes en la informática ya que permiten representar datos como secuencias de bits. Un programa es un algoritmo que indica a la computadora qué pasos específicos debe seguir para desarrollar una tarea.

## Instalanado Visual Studio 2022

Lo primero que debemos hacer es descargar Visual Studio, para eso nos dirigimos al sitio oficial de Visual Studio y nos dirigimos a la seccion de descarga.

Link de descarga: https://visualstudio.microsoft.com/es/downloads/

Una vez estamos en la seccion de descargas buscamos la version gratuita que lleva por nombre "Visual Studio Community" y es la version en la cual trabajaremos. Cabe resaltar que esta version Community tiene todo el potecial y herramientas para desarrollar a nivel profesional.

++Las versiones que existen de Visual Studio disponibles para descargar son:++

Visual Studio Community - Gratuito
Visual Studio Professional - De pago
Visual Studio Enterprise - De pago
++Otras versiones para trabajar son:++

Visual Studio for MacOSX - Gratuito y solamente de uso para sistemas operativos MacOSX
Visual Studio Code - Editor de código fuente independiente que se ejecuta en Windows, macOS y Linux. La selección principal para desarrolladores web y Java, con toneladas de extensiones para admitir casi cualquier lenguaje de programación.
Lo mas recomendable es usar el IDE de Visual Studio pero en cualquiera de los casos lse descarga un instalador el cual ejecutaremos e instalaremos.

En el proceso de instalacion nos pedira instalar los paquetes con los que deseamos trabajar y el tema de VS.

## Tipos de datos primitivos

El tipo de datos es el que le dice al compilador de c# que tipo de valor puede almacenar una variable. Ademas, c# es un lenguaje fuertemente tipado lo que significa que el valor de una variable de un tipo concreto, no se puede usar como si fuera de otra tipo.

int, bool, float, double, char, string, long, uint

## LA PALABRA RESERVADA VAR

La palabra clave var permite declarar una variable local (dentro de un método o un bucle) sin indicar explícitamente el tipo de datos - en cambio, el compilador de C# infiere el tipo desde la parte derecha de la declaración.

++¿Cuándo usar var en C#?++ Puedes usar var en cualquier momento en que la inicialización de la variable te indica claramente qué valores contendrá la variable.

Ten en cuenta que, en todos estos casos, los nombres de las variables deben ser descriptivos y el inicializador debe ser claro. También pluraliza enumeraciones y arreglos.

++Ejemplos++ Por ejemplo, lo siguiente declara una variable e inicializa su valor como una cadena de texto:

```csharp
string message = "Hola";
```

En este ejemplo, usamos el tipo string para la variable message al comienzo de la declaración y una cadena de texto como valor inicial. La variable message es de tipo explícito.

Sin embargo, a partir del valor "Hola", el compilador puede inferir la variable como una cadena. Por lo tanto, el tipo explícito al comienzo de la declaración es redundante.

Para evitar esta redundancia, puedes usar la palabra clave var en lugar del tipo explícito al comienzo de la declaración de la variable de esta manera:

```csharp
var message = "Hola";
```

En este ejemplo, el message es una variable de tipo implícito.

La palabra clave var no indica un tipo especial de variable. Es una forma abreviada sintáctica de cualquier tipo que el compilador pueda inferir a partir de la inicialización de una declaración de variable.

En el ejemplo anterior, var es la abreviatura del tipo string.

Una vez que el compilador puede inferir el tipo de la variable, es fijo e inmutable. Por ejemplo, no puedes asignar un número entero a la variable message de esta manera:

```csharp
var message = "Hola";
message = 100; // error
```

C# solo permite usar la palabra clave var con una variable que incluye una inicialización. Lo siguiente resultará en un error:

```csharp
var amount;

Error: Implicitly typed variables must be initialized
```
## Operador Aritmeticos
<aside> 📌 Podemos comentar en el editor con `//`, lo que permite ingresar anotaciones para nosotros y otros colaboradores con los que estemos trabajando. Dichos comentarios no afectan a la ejecución del código y también pueden servir para sacar alguna porción de nuestro trabajo para que no se ejecute pero sin necesidad de borrarlo </aside>
• El doble slash sirve para comentar UNA línea pero no si queremos hacer saltos de línea. En este último caso lo haremos con /* */

Originalmente las computadoras se usaban para realizar calculos muy bestiales por lo que tenemos a disposición multitud de signos que podemos usar para nuestros cálculos:

Suma: +
Resta: -
Multiplicación: *
División: /
Módulo o Resto (lo que te quedaba de una división): %
Incremento (sería un +1): ++
Decremento (-1): –
