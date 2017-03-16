using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Categoria
{
    public interface IContratoModificarCategoria
    {
        string id_Categoria { get; set; }
        DropDownList activo { get; set; }
        DropDownList destacado { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}

