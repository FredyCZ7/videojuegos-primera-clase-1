// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola chavales");

// Declaracion de variables
int num;
num = 9;
int num2 = 23;
float estatura = 1.7f;
double peso = 70.6;
string nombre = "fredy";

// operaciones aritmeticas
/*
+ => entre string o string y numeros concatenados 
+ => entre numeros es suma
% => para obtener el resto
= => para asignar valores
*/
Console.WriteLine(7 % 5);
int edad = 30;
Console.WriteLine("La edad es " + (edad + 1));

edad = 30;
Console.WriteLine("La edad es " + edad++);
Console.WriteLine("La edad es " + edad);

edad = 30;
Console.WriteLine("La edad es " + ++edad);
Console.WriteLine("La edad es " + edad);

// operaciones cortas +=, -= , *= , /= , %=

// operadores logicos
// >,<,>=,<=,==,!=,&&,&,
num = 2;
Console.WriteLine((1 > 3) & (3 > num++));
Console.WriteLine("num=" + num);

