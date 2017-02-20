using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCC.InterfazDAO.BackOffice
{
    public interface IDaoMarca: IDao
    {
        bool Agregar(Dominio.Entidad parametro);
    }
}
