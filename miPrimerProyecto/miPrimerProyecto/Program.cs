﻿using System;
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
            //2. Switch ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.

            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("\n\n *** MENU ***");
                Console.WriteLine("1. Promedio Notas");
                Console.WriteLine("2. Promedio Serie Numeros");
                Console.WriteLine("3. Clasificacion edad");
                Console.WriteLine("4. Tabla Multiplicar");
                Console.WriteLine("5. Salir");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();//limpiar la consola
                switch (opcion) {
                    case 1://if(opcion==1)
                        promedio();

                    case 3: //if(opcion==3)
                        ClasificacionEdad();
                        break;
                    case 4:
                        tablaMultiplicar();
                        break;
                    case 5: //if(opcion==5)
                        continuar = "n";
                        break;
                    default://else


                }
            }
        }

        static void tablaMultiplicar()
        {
            Console.Write("Tabla: ");
            int ntabla = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {//i++ => i = i + 1
                Console.WriteLine("{0}x{1}={2}", ntabla, i, ntabla * i);
            }
        }
        static void promedio()
        {
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());
        }
    }
}


