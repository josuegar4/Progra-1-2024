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
            Conversores objConversor = new Conversores();
            string continuar = "s";
            while (continuar == "s")
            {

                Console.WriteLine("------  MENU  ------");
                Console.WriteLine("1.Monedas.");
                Console.WriteLine("2.Longitud.");
                Console.WriteLine("3.Masa.");
                Console.WriteLine("4.Tiempo.");
                Console.WriteLine("0.Salir.");
                Console.WriteLine("Opcion:");
                int Opcion = int.Parse(Console.ReadLine());

                if (Opcion == 0)
                {
                    continuar = "n";

                }

                else {
                    Console.Clear();
                    for (int i = 1; i < objConversor.etiquetas[Opcion].Length; i++)
                    {
                        Console.WriteLine("{0}. {1}", i, objConversor.etiquetas[Opcion][i]);
                    }
                }
                Console.Write("De: ");
                int de = int.Parse(Console.ReadLine());

                Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Cantidad: ");
                double cantidad = double.Parse(Console.ReadLine());

                Console.WriteLine("{0} \n", objConversor.convertir(de, a, cantidad, Opcion));
            }

        }
    }
}




