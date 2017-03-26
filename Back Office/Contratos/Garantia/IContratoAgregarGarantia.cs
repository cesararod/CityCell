using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Garantia
{
    public interface IContratoAgregarGarantia
    {
        string id { get; set; }
        DropDownList marca { get; set; }
        DropDownList cateoria { get; set; }
        string descripcion { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
