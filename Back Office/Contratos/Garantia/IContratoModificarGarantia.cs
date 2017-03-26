using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Garantia
{
    public interface IContratoModificarGarantia
    {
        string idGar { get; set; }
        string descripcion { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
