using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion1
{
    class Numeros_Impares
    {
        public void Muestraimpares()
        {
            Console.Write("Desde que numero desea los numeros impares: ");
            int numero = int.Parse(Console.ReadLine());
            for (int a = 0; a < numero; a++)
            {
                int b = a;
                if ((b % 2) == 0)
                {
                }
                else
                {
                    Console.Write(" " + b); //Imprimere todos los numeros impares
                }
            }
            Console.ReadKey();
        }
    }
}
