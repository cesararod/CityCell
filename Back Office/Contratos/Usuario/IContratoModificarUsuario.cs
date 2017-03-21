using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Usuario
{
    public interface IContratoModificarUsuario
    {
        string UsuId { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Cedula { get; set; }
        string Telefono { get; set; }
        string Celular { get; set; }
        string Password { get; set; }
        string Correo { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
