using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion1
{
    class Area_Circulo
    {
        public void Areacirculo() 
        {
            Console.WriteLine(" Calcular circunferencia y area del circulo");

           /*La circunferencia de un circulo  es igual a dos veces el radio (r) por π.  C = π * (r* 2)
           El área de un círculo es pi multiplicado por el radio al cuadrado. A = π r². */

            Console.Write("Ingrese el radio del circulo:");
            double radio = double.Parse(Console.ReadLine());
            double circunferencia = 3.1416 * (radio * 2), area = 3.1416 * (radio * radio);

            Console.WriteLine("La Circunferencia del Circulo es: {0}", circunferencia);
            Console.WriteLine("El Area del circulo es: {0}", area);
            Console.ReadKey();
        }
    }
}
