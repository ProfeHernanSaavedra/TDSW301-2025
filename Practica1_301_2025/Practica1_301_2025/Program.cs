using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_301_2025
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear(); // aplica toda la consola

            Console.Write("Ingrese un numero: ");
            texto = Console.ReadLine();

            if (texto == null){
                texto = string.Empty;
            }
            int largo = texto.Length;

            if (largo % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine(texto);
            }

            Console.ResetColor();
           
            Console.WriteLine();
            Console.WriteLine("El largo del texto es: "+largo);

            Console.ReadLine();
        }
    }
}
