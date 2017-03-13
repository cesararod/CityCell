using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Promocion
{
    public interface IContratoAgregarPromocion
    {
        string precio { get; set; }
        string Fecha_Inicio { get; set; }
        string Fecha_Fin { get; set; }
        DropDownList activo { get; set; }
        DropDownList producto { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
