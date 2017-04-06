using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Producto
{
    public interface IContratoModificarProducto
    {
        string id_Producto { get; set; }
        string nombre { get; set; }
        string modelo { get; set; }
        string descripcion { get; set; }
        string precio { get; set; }
        string cantidad { get; set; }  
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
