using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public interface IContratoGenerarCategoria
    {
        string moneda { get; set; }
        string fecha { get; set; }
        string compania { get; set; }
        string proyecto { get; set; }
        string descripcion { get; set; }
        string monto { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
