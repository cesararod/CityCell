using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Producto
{
    public interface IContratoActivar
    {
        string UsuPro { get; set; }
        string activo { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
