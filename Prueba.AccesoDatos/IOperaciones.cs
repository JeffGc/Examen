using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.AccesoDatos
{
    public interface IOperaciones<T>
    {
        void Insertar(T Item);

        T Buscar(int Id);

        List<T> BuscarTodos();

        void Modificar(T Item);

        void Eliminar(T Item);
    }
}
