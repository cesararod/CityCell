using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Producto
{
    public interface IContratoAgregarProducto
    {
        string nombre { get; set; }
        string modelo { get; set; }
        string descripcion { get; set; }
        string precio { get; set; }
        string cantidad { get; set; }
        string alto { get; set; }
        string ancho { get; set; }
        string largo { get; set; }
        string peso { get; set; }
        DropDownList activo { get; set; }
        DropDownList marca { get; set; }
        DropDownList categoria { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
