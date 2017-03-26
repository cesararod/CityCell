using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Correo
{
    public interface IContratoCorreo
    {
        string numero { get; set; }
        string destinatario { get; set; }
        string asunto { get; set; }
        string mensaje { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
