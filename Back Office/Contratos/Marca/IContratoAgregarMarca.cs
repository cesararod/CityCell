using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Marca
{
    public interface IContratoAgregarMarca
    {
        string nombre { get; set; }
        DropDownList activo { get; set; }
        string ruta_logo { get; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
