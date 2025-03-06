// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//1.Escribe un programa en C# que solicite un número entero x al usuario y imprima el resultado de sumarlo al cuadro.
Console.WriteLine("\n");
Console.WriteLine("Escribe un número entero: ");
int x = Convert.ToInt32(Console.ReadLine());
int readultado = x + (x * x);
Console.WriteLine("El resultado de sumar el número al cuadrado es: " + readultado);

//2.Escribe un programa en C# que multiplique por tres factores.
//Solicita tres números al usuario y muestra el resultado de multiplicarlos entre sí.
Console.WriteLine("\n");
Console.WriteLine("Escribe el primer número: ");
var factor1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Escribe el segundo número: ");
var factor2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Escribe el tercer número: ");
var factor3 = Convert.ToDecimal(Console.ReadLine());

var resultado = factor1 * factor2 * factor3;
Console.WriteLine("El resultado de multiplicar los tres factores es: " + resultado);

//3.Escribe un programa en C# que solicite dos números enteros al usuario (x, y) y imprima el resultado de la división
//y el resto de la división en una nueva linea.

Console.WriteLine("\n");
Console.WriteLine("Escribe el primer número entero: ");
int entero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escribe el segundo número entero: ");
int entero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El resultado de la división es: " + entero1 / entero2);
Console.WriteLine("El resto de la división es: " + entero1 % entero2);

//4. Cree un programa en C# que solicite dos números al usuario (x, y) y muestre el resultado de su división.
//Tendrá que controlar la división por 0 con el uso de la excepción DivideByZeroException en un bloque try-catch.
//Si el usuario intenta dividir por 0 muestre No se puede dividir por 0.
Console.WriteLine("\n");
Console.WriteLine("Escribe el primer número: ");
var numero1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escribe el segundo número: ");
var numero2 = Convert.ToDecimal(Console.ReadLine());

try
{
    Console.WriteLine("El resultado de la división es: " + numero1 / numero2);
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir por 0");
}

//5.Crea un programa en C# que solicite un número entero x al usuario y imprima el resultado de las siguientes operaciones:
//-6 + x * 5
//(13 - 2) * x
//(x + -2) * (20 / 10)
//(12 + x) / (5 - 4)

Console.WriteLine("\n");
Console.WriteLine("Escribe un número entero: ");
int numero = Convert.ToInt32(Console.ReadLine());
var resultado1 = -6 + numero * 5;
var resultado2 = (13 - 2) * numero;
var resultado3 = (numero + -2) * (20 / 10);
var resultado4 = (12 + numero) / (5 - 4);
Console.WriteLine($"El resultado de la operación -6 + {numero} * 5 es: " + resultado1);
Console.WriteLine($"El resultado de la operación (13 - 2) * {numero} es: " + resultado2);
Console.WriteLine($"El resultado de la operación ({numero} + -2) * (20 / 10) es: " + resultado3);
Console.WriteLine($"El resultado de la operación (12 + {numero}) / (5 - 4) es: " + resultado4);

//6.Escribe un programa en C# que calcule la medía aritmética de 4 factores introducidos por el usuario, uno por cada linea.
Console.WriteLine("\n");
Console.WriteLine("Escribe un primer número: ");
var factor5 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escribe un segundo número: ");
var factor6 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escribe un tercer número: ");
var factor7 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escribe un cuarto número: ");
var factor8 = Convert.ToDecimal(Console.ReadLine());
var resultado5 = (factor5 + factor6 + factor7 + factor8) / 4;
Console.WriteLine("La media aritmética de los cuatro factores es: " + resultado5);

//7.Escriba un programa en C# que solicite tres números (a, b, c) y
//muestre el resultado de (a+b)*c y el resultado de a*c + b*c.
Console.WriteLine("\n");
Console.WriteLine("Escribe el primer número: ");
var a = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escribe el segundo número: ");
var b = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escribe el tercer número: ");
var c = Convert.ToDecimal(Console.ReadLine());
var resultado6 = (a + b) * c;
var resultado7 = a * c + b * c;
Console.WriteLine("El resultado de (a+b)*c es: " + resultado6);
Console.WriteLine("El resultado de a*c + b*c es: " + resultado7);


//8.Escriba un programa en C# para mostrar ciertos valores de la función y= x2 - 2x + 1.
//Solicite al usuario el rango de números enteros x para mostrar la función.
Console.WriteLine("\n");
Console.WriteLine("Escribe el primer número del rango: ");
var rango1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escribe el segundo número del rango: ");
var rango2 = Convert.ToInt32(Console.ReadLine());
for (int i = rango1; i <= rango2; i++)
{
    var resultado8 = i * i - 2 * i + 1;
    Console.WriteLine($"El resultado de la función y = x2 - 2x + 1 para x = {i} es: " + resultado8);
}