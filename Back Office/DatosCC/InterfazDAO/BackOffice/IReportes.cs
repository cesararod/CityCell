using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace DatosCC.InterfazDAO.BackOffice
{
    public interface IReportes
    {
        List<Entidad> ConsultarTodos(Dominio.Entidad parametro);  
    }
}
