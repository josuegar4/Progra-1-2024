using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TAREA: Obtener la nota final por computo y Nota Final de la matera de Programacion I.

            //Computo 1
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine()); //8
            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine()); //9
            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine()); //7
            // 8*30%= 2.4
            // 9*30%= 2.7
            // 7*40%= 2.8
            //C1    = 7.9

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es: {0}", c1);

            //Computo 2
            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 2: ");
            parcial1 = double.Parse(Console.ReadLine()); //7

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0}", c2);

            //Computo 3
            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine()); //8

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine()); //9

            Console.Write("Parcial 3: ");
            parcial1 = double.Parse(Console.ReadLine()); //7

            double c3 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C3 es: {0}", c3);

            // Calcular el promedio de C1 y C2 y C3
            double promedioFinal = (c1 + c2 + c3) / 3;
            Console.WriteLine("La nota final promedio es: {0}", promedioFinal);

            //Pausa.
            Console.ReadLine();
        }
    }
}
