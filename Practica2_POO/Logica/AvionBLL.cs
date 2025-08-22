using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AvionBLL : IAvionBLL
    {
        private static List<Avion> aviones = new List<Avion>();

        public void Agregar(Avion a)
        {
            if (buscarAvion(a.Codigo) == false)
            {
                aviones.Add(a);
            }
            else
            {
                Console.WriteLine("Avion ya existe!!");
            }
            
        }

        public bool buscarAvion(int codigo)
        {
            foreach (Avion a in aviones)
            {
                if (a.Codigo == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Avion> Listar()
        {
            //List<Avion> avionesOrdenados = new List<Avion>();
            //int min = 9999; 
            //foreach (Avion av in aviones) // 2020  2025  2019
            //{
            //    if (av.AñoFabricacion < min)
            //    {
            //        min = av.AñoFabricacion;
                    
            //    }
                
            //}
          
            return aviones.OrderBy(a => a.AñoFabricacion).ToList();
            
        }

        public List<Avion> Listar(Estado grupo)
        {
          
            return aviones.FindAll(a => a.Grupo == grupo);
        }
    }
}
