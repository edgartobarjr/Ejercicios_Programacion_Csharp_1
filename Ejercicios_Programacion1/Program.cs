using System;

namespace Ejercicios_Programacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu Programa
            Menu:
            Console.Clear();
            Console.WriteLine("Examen de Programacion\n" + "\nA continuacion se muestra un listado de los ejercicios, para comprobarlos escribe el numero correlativo de cada uno\n");
            Console.WriteLine("1er. Calcular el area de un circulo y su circunferencia.");
            Console.WriteLine("2do. Calcular la superficie de un triangulo.");
            Console.WriteLine("3er. Mostar los numeros impares por un Usuario");
            Console.WriteLine("4ta. Definir un conteo para media de pesos.");
            Console.WriteLine("5ta. Imprimir recibo de pago a empleado.");
            Console.WriteLine("6ta. Salir.");

            Console.WriteLine("\nDigite la Opcion del Ejercicio: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Clear();
                    Area_Circulo ac = new Area_Circulo();
                    ac.Areacirculo();
                    goto Menu;

                case 2:
                    Console.Clear();
                    Superficie_Triangulo sp = new Superficie_Triangulo();
                    sp.Superficietriangulo();
                    goto Menu;

                case 3:
                    Console.Clear();
                    Numeros_Impares ni = new Numeros_Impares();
                    ni.Muestraimpares();
                    goto Menu;

                case 4:
                    Console.Clear();
                    Conteo_Peso cp = new Conteo_Peso();
                    cp.Mediadepesos();
                    goto Menu;

                case 5:
                    Console.Clear();
                    Sueldo_Empleado se = new Sueldo_Empleado();
                    se.Pagodesueldoo();
                    goto Menu;

                case 6:
                    break;

                default:
                    goto Menu;
            }
        }
     }
 }

