using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DatosCC.InterfazDAO
{
    public interface IDao
    {
        bool Agregar(Dominio.Entidad parametro);
        bool Modificar(Dominio.Entidad parametro);
        Dominio.Entidad ConsultarXId(Dominio.Entidad parametro);
        List<Entidad> ConsultarTodos();  
    }
}
