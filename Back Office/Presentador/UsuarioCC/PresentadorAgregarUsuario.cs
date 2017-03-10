using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos.Usuario;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.UsuarioCC
{
    public class PresentadorAgregarUsuario
    {
        IContratoAgregarUsuario vista;

        public PresentadorAgregarUsuario(IContratoAgregarUsuario vista)
        {
            this.vista = vista;
        }

        /// <summary>
        /// Método para manejar los errores y mensajes a interfaz
        /// </summary>
        public void Alerta(string msj)
        {
            vista.alertaClase = RecursoPresentadorUsuario.alertaError;
            vista.alertaRol = RecursoPresentadorUsuario.tipoAlerta;
            vista.alerta = RecursoPresentadorUsuario.alertaHtml + msj + RecursoPresentadorUsuario.alertaHtmlFinal;
        }

    }
}
