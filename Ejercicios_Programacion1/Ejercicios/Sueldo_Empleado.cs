using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion1
{
    class Sueldo_Empleado
    {
        //Pago de Sueldo de un Empleado
        public void Pagodesueldoo()
        {
            Console.WriteLine("Facturacion de Empleado.");
            Console.Write("Ingrese el Nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese Salario por Hora: ");
            double salariohora = double.Parse(Console.ReadLine());

            Console.Write("Ingrese Antiguedad del empleado: ");
            double antiguedad = double.Parse(Console.ReadLine());

            Console.Write("Ingrese total de horas Trabajadas: ");
            double horastrabajadas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese los Bonos del Trabajador: ");
            double bonos = double.Parse(Console.ReadLine());

            double totalbruto = (horastrabajadas * salariohora) + (antiguedad * bonos); //El total Bruto (TB= (HorasT * SalarioH) + (antiguedad * bonos))
            double descuento = totalbruto * 0.12; //Descuento = TB * IVA 
            double totalneto = totalbruto - descuento; // TN = TB - Descuento

            Console.Clear();

            Console.WriteLine("FACTURA");
            Console.WriteLine("El emplead@: " + nombre);
            Console.WriteLine("Que tiene {0} años de antiguedad", antiguedad);
            Console.WriteLine("Tiene un salario de: Q.{0} por hora", salariohora);
            Console.WriteLine("Devenga al mes: Q.{0}.", totalbruto);
            Console.WriteLine("Menos: Q.{0}, por concepto de descueto.", descuento);
            Console.WriteLine("Quedando un Total Neto de: Q.{0}", totalneto);
            Console.ReadKey();
        }
    }
}