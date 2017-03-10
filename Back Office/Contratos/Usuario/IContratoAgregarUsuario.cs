using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Contratos.Usuario
{
    public interface IContratoAgregarUsuario
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Cedula { get; set; }
        DropDownList Genero { get; set; }
        string Telefono { get; set; }
        string Celular { get; set; }
        string Password { get; set; }
        string Fecha_Nnacimiento { get; set; }
        string Correo { get; set; }
        DropDownList Rol { get; set; }
        DropDownList TipoDoc { get; set; }
        string alertaClase { set; }
        string alertaRol { set; }
        string alerta { set; }
    }
}
