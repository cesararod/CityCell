using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Venta
{
    public interface IContratoCorreo
    {
        string VenId { get; set; }
        string Status { get; set; }
        string Mail { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
