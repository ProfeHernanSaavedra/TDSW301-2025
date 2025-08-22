using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IAvionBLL
    {
        void Agregar(Avion a);
        List<Avion> Listar();
        List<Avion> Listar(Estado grupo);

    }
}
