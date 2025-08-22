using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum Estado
    {
        Disponible,
        Reparado,
        Retirado
    }

    public class Avion
    {
        private int _codigo;
        private int _añoFabricacion;
        private Estado _grupo;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public int AñoFabricacion { get => _añoFabricacion; set => _añoFabricacion = value; }
        public Estado Grupo { get => _grupo; set => _grupo = value; }

        public Avion()
        {
            //Codigo = 123;
            //AñoFabricacion = 2020;
            //Grupo = Estado.Disponible;

        }

        public Avion(int codigo, int año)
        {
            Codigo = codigo;
            AñoFabricacion = año;
        }

        public override string ToString()
        {
            return Codigo + " " + AñoFabricacion + " " + Grupo;
        }
    }
}
