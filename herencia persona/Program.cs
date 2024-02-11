// See https://aka.ms/new-console-template for more information
using herencia_persona;

Console.WriteLine("herencia");
Console.WriteLine();


// Instanciar las clases y solicitar datos al usuario
Estudiante estudiante = new Estudiante();
Console.WriteLine("Ingrese el nombre del estudiante:");
estudiante.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese la dirección del estudiante:");
estudiante.Direccion = Console.ReadLine();
Console.WriteLine("Ingrese el correo del estudiante:");
estudiante.Correo = Console.ReadLine();
Console.WriteLine("Ingrese la carrera del estudiante:");
estudiante.Carrera = Console.ReadLine();

Profesor profesor = new Profesor();
Console.WriteLine("Ingrese el nombre del profesor:");
profesor.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese la dirección del profesor:");
profesor.Direccion = Console.ReadLine();
Console.WriteLine("Ingrese el correo del profesor:");
profesor.Correo = Console.ReadLine();
Console.WriteLine("Ingrese la asignatura del profesor:");
profesor.Asignatura = Console.ReadLine();

// Imprimir los datos de los objetos creados
Console.WriteLine("\nDatos del estudiante:");
estudiante.ImprimirDatos();

Console.WriteLine("\nDatos del profesor:");
profesor.ImprimirDatos();