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

            //ejercicio 5.
            Console.WriteLine("Ingrese un numero entero: ");
            string numeros = Console.ReadLine();

            int suma = 0;

            foreach (char num in numeros)
            {
                if (char.IsDigit(num)) //solo sumando si es un número
                {
                    /*string palabra = "" + 2; --> convierte el numero a string
                    string pala = 2 + "";
                    Console.WriteLine(pala + 4);
                    int dato = 3;
                    Console.WriteLine(dato +4);
                    */
                    int digito = num - '0'; //convierte char a int
                    suma = suma + digito; //suma += digito;
                    //"45"
                    //'4' - '0' --> 4
                    //'5' - '0' --> 5
                }
            }

            Console.WriteLine("La suma de los digitos es: "+suma);
            // --- fin ejercicio 5 -----

            // ---- ejercicio 6 ------

            Console.WriteLine("Ingrese una cantidad numérica: ");
            int cantidad = int.Parse(Console.ReadLine());

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            List<int> primos = new List<int>();

            int numero = 1;
            
            while (numero <= cantidad) //|| impares.Count < cantidad )//|| primos.Count < cantidad)
            {
                //pares
                if (numero%2 == 0 && pares.Count < cantidad)
                {
                    pares.Add(numero);
                }
               
                //impares
                else
                    Console.WriteLine("hola par");
                {
                   if (numero % 2 != 0 && impares.Count < cantidad)
                    {
                        impares.Add(numero);
                    }
                }
                numero++;
            }

            Console.WriteLine("Numeros Pares: " + pares.Count);
            Console.WriteLine("Numeros imPares: " + impares.Count);

            // ---- fin jercicio 6 ----


            Console.ReadLine();
        }
    }
}
