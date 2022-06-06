using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion1
{
    class Superficie_Triangulo
    {
        public void Superficietriangulo()
        {
            Console.WriteLine(" Calcular Superficie de un Triagulo.");
            Console.Write("Ingresa la dimencional para los datos:");
            string dimencional = Console.ReadLine();

            Console.Write("Ingrese la base del triangulo: ");
            double base1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la Altura del triangulo: ");
            double altura = double.Parse(Console.ReadLine());

            double superficie = (altura * base1) / 2;
            Console.WriteLine("El triangulo con base {0}{3} y con altura {1}{3} tien un area de {2}{3}. ", base1, altura, superficie, dimencional);
            Console.ReadKey();
        }
    }
}
