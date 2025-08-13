using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //'0' '1' ....'9'
            //string[] dias = new string[7];
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            Console.WriteLine(dias[0]);
            //for + tab + tab
            Console.WriteLine("\nRecorrido con for");
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
            }

            Console.WriteLine("\nRecorrido con foreach");
            //fore + tab + tab
            foreach (string dia in dias)
            {
                Console.WriteLine(dia);
            }

            //matrices --> dos dimensiones filas,columnas
            int[,] sala = new int[8, 10];
            Random rand = new Random();

            Console.WriteLine("\nMatriz de {0} x {1}",sala.GetLength(0),sala.GetLength(1));
            Console.WriteLine("Contenido en la posición 0,0: "+sala[0,0]);

            Console.WriteLine("\nRecorrido con for");
            for (int f = 0; f < sala.GetLength(0); f++)
            {
                for (int c = 0; c < sala.GetLength(1); c++)
                {
                    sala[f, c] = rand.Next(0,2);
                    Console.Write(sala[f,c] + " ");
                }
                Console.WriteLine("");
            }

            //listas
            Console.WriteLine("\n\nListas");
            List<string> colores = new List<string>();

            colores.Add("rojo");
            colores.Add("verde");
            colores.Add("azul");
            colores.Add("amarillo");

            Console.WriteLine("Primer elemento: "+ colores[0]);

            Console.WriteLine("\nRecorrido por foreach");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            colores.Add("Blanco");

            Console.WriteLine("\nRecorrido por foreach");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            colores.Insert(0, "negro");

            Console.WriteLine("\nRecorrido por foreach");
            foreach (string color in colores)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Total de elementos en la lista es: " + colores.Count);

            Console.ReadLine();


        }
    }
}
