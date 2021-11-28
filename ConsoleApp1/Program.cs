using System;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Title = "Mi Primer Programa en C#";
Console.WriteLine("Hello World!");
var nombre = Console.ReadLine();

if (!string.IsNullOrEmpty(nombre))
    Console.WriteLine($"Como te va {nombre}?");
else
    Console.WriteLine("Este es mi programa con .NET");

int edad = 0;

Console.WriteLine("Indica tu edad");

edad = Convert.ToInt32(Console.ReadLine());

var fecha = DateTime.Today.AddYears(edad * -1);

Console.WriteLine($"Tu naciste en el año {fecha.Year}");
Console.ReadLine();