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
            // Definir la matriz con rangos y tasas de ISR
            double[,] matriz = {
            { 0, 472.00, 10, 0 },     // Menor o igual a 472.00 (tasa 10%, sin monto fijo)
            { 472.01, 895.24, 20, 47.20 }, // Desde 472.01 hasta 895.24 (tasa 20%, monto fijo 47.20)
            { 895.25, 2038.10, 30, 172.20 }, // Desde 895.25 hasta 2038.10 (tasa 30%, monto fijo 172.20)
            { 2038.11, double.MaxValue, 35, 417.20 } // Desde 2038.11 en adelante (tasa 35%, monto fijo 417.20)
        };

            // Solicitar el sueldo al usuario
            Console.Write("Sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());

            // Calcular AFP (6.25% del sueldo)
            double afp = sueldo * 6.25 / 100;

            // Calcular ISSS (3% del sueldo)
            double isss = sueldo * 3 / 100;

            // Inicializar ISR
            double isr = 0;

            // Deducir AFP del sueldo
            sueldo -= afp;

            // Calcular ISR según las tablas definidas en la matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (sueldo >= matriz[i, 0] && sueldo <= matriz[i, 1])
                {
                    isr = (sueldo - (matriz[i, 0] - 0.01)) * matriz[i, 2] / 100 + matriz[i, 3];
                    break; // Salir del bucle una vez que se encuentra el rango correcto
                }
            }

            // Deducir ISSS e ISR del sueldo
            sueldo -= isss;
            sueldo -= isr;

            // Imprimir los resultados
            Console.WriteLine("Sueldo Neto: {0}, AFP: {1}, ISSS: {2}, ISR: {3}",
                Math.Round(sueldo, 2),
                Math.Round(afp, 2),
                Math.Round(isss, 2),
                Math.Round(isr, 2));

            // Esperar que el usuario presione una tecla para cerrar la consola
            Console.ReadLine();

        }
    }
}


