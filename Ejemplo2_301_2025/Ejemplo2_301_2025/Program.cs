using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_301_2025
{
    class Program
    {
        static void Main(string[] args)
        {
           

            

            int num1 = 4, num2 = 5, num6;
            int suma;
            string nombre = "Profe Hernán";
            bool esCSharp = true;
            float num3 = 3.5f;
            decimal num4 = 2.5m;
            string num5 = "14";

            suma = num1 + num2 + (int)num3 + (int)num4 + int.Parse(num5);

            //cw + tab + tab 
            Console.WriteLine("la suma es: " +suma);
            Console.WriteLine("Hola "+ nombre);
            Console.WriteLine("Lenguaje C#: "+esCSharp);

            Console.Write("Ingrese un valor para num6: ");
            //num6 = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out num6);

            suma += num6; //acumulador --> suma = suma + num6
            Console.WriteLine("la suma es: " + suma);

            Console.ReadLine();
        }
    }
}
