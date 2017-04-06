using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Reportes
{
    public interface IContratoReporte3
    {
        string TablaReporte { get; set; }
        string Fecha_Inicio { get; set; }
        string Fecha_Fin { get; set; }
        DropDownList categoria { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
