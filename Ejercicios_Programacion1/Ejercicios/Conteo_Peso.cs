using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion1
{
    class Conteo_Peso
    {
        public void Mediadepesos()
        {
            int contmas = 0;  
            int contmenos = 0; 
            int b = 0;

            Console.WriteLine("Calcular Media de Pesos.");
            Console.Write("Ingrese cantidad de muestras para comprobar: ");
            int veces = int.Parse(Console.ReadLine()); //Numero de personas que se van a introducir
            Console.Write("Que media de peso desea saber: ");
            double pes = double.Parse(Console.ReadLine());
            for (int i = 1; i <= veces; i++)
            {
                b++; //Lleva el conteo de las personas
             
                Console.WriteLine("Ingrese el peso numero: " + b);
                double peso = double.Parse(Console.ReadLine());
                if (peso <= pes)
                {
                    contmenos++;
                }
                else
                {
                    contmas++;
                }
            }
            Console.WriteLine("El numero de pesos mayores de: " + pes +  " lbs es de: " + contmas);
            Console.WriteLine("El numero de pesos menores de: " + pes +  " lbs es de: " + contmenos);
            Console.ReadKey();
        }
    }
}
