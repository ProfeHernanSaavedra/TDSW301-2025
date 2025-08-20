using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Juan";
            persona.Apellido = "Perez";
            persona.FechaNacimiento = new DateTime(1980, 8, 6);

            Console.WriteLine("Hola " + persona.Nombre);
            Console.WriteLine("Hola " + persona);
            Console.WriteLine("Tienes "+persona.Edad() + " años");

            Persona persona2 = new Persona("Maria", "Lopez");
            persona2.FechaNacimiento = new DateTime(1982, 11, 2);
            Console.WriteLine("Hola "+persona2.Nombre);
            Console.WriteLine("Tienes " + persona2.Edad() + " años");

            Console.ReadLine();


        }
    }
}
