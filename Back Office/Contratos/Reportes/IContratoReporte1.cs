using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Reportes
{
    public interface IContratoReporte1
    {
        string TablaReporte1 { get; set; }
        string Fecha_Inicio { get; set; }
        string Fecha_Fin { get; set; }
        DropDownList Estado { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
