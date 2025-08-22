using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            
            AvionBLL control = new AvionBLL();
            do
            {
                Avion avion = new Avion();
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("1. Ingresar nuevo avión");
                Console.WriteLine("2. Listar aviones ordenados por año de fabricación");
                Console.WriteLine("3. Listar Aviones 'Reparados'");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    avion.Codigo = codigo;
                    Console.WriteLine("Ingrese Año Fabricación: ");
                    int año = int.Parse(Console.ReadLine());
                    avion.AñoFabricacion = año;
                    Console.WriteLine("--Elija tipo Estado--");
                    Console.WriteLine("1. Disponible");
                    Console.WriteLine("2. Reparado");
                    Console.WriteLine("3. Retirado");
                    int opcionEstado = int.Parse(Console.ReadLine());
                    if (opcionEstado == 1)
                    {
                        avion.Grupo = Estado.Disponible;
                    }
                    else
                    {
                        if (opcionEstado == 2)
                        {
                            avion.Grupo = Estado.Reparado;
                        }
                        else
                        {
                            avion.Grupo = Estado.Retirado;
                        }
                    }

                    control.Agregar(avion);

                }
                if (opcion == 2)
                {
                    Console.WriteLine("Aviones ordenados por año de fabricación");
                    Console.WriteLine("****************************************");
                    foreach (Avion a in control.Listar())
                    {
                        Console.WriteLine(a);
                    }   
                }
                if (opcion == 3)
                {
                    Console.WriteLine("Los Aviones en estado reparado son: ");
                    Console.WriteLine("************************************");
                    foreach (Avion  a in control.Listar(Estado.Reparado))
                    {
                        Console.WriteLine(a);
                    }
                }

            } while (opcion != 4);

        }
    }
}
