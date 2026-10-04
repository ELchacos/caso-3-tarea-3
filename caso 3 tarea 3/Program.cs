using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso_3_tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   //definimos las variables
            decimal celsius;
            decimal fahrenheit;
            //le pedimos los grados al usuario
            Console.WriteLine("ingrese la temperatura en grados Celsius:");
            while (!decimal.TryParse(Console.ReadLine(), out celsius) || celsius < -273.15m)
            {
                Console.WriteLine("Entrada inválida. Ingrese un número mayor o igual a -273.15:");
            }

            //calculamos los grados Fahrenheit
            fahrenheit = celsius * 9 / 5 + 32;

            //mostramos el resultado al usuario
            Console.WriteLine($"Grados Celsius: {celsius}");
            Console.WriteLine($"Grados Fahrenheit: {fahrenheit}");
        }
    }
}
