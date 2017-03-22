using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Venta
{
    public interface IContratoModificarVenta
    {
        string VentaId { get; set; }
        DropDownList Estatus { get; set; }
        string Nombre { get; set; }
        string Producto { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
