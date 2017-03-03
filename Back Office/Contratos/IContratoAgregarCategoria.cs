using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos
{
    public interface IContratoGenerarCategoria
    {
        string nombre { get; set; }
        string activo { get; set; }
        DropDownList destacado { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
