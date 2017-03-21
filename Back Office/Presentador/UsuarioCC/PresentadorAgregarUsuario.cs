using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Globalization;
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

        /// <summary>
        /// Método para llenar los generar usuario
        /// </summary>
        public void GenerarUsuario()
        {
            try
            {
                Usuario elUsuario = (Usuario)FabricaEntidades.UsuarioVacio();
                elUsuario.Nombre = vista.Nombre;
                elUsuario.Apellido = vista.Apellido;
                elUsuario.Cedula = vista.Cedula.ToString();
                elUsuario.Tipo_Documento = vista.TipoDoc.SelectedValue.ToString();
                elUsuario.Telefono = vista.Telefono;
                elUsuario.Celular = vista.Celular;
                elUsuario.Password = vista.Password;
                elUsuario.Fecha_Nacimiento = DateTime.ParseExact
                (vista.Fecha_Nnacimiento, "MM/dd/yyyy", CultureInfo.InvariantCulture);// vista.Fecha_Nnacimiento.ToString();
                elUsuario.Fecha_Ingreso = DateTime.Now;
                elUsuario.Email = vista.Correo;
                elUsuario.Fk_Genero = int.Parse(vista.Genero.SelectedValue.ToString());
                elUsuario.Fk_Rol = int.Parse(vista.Rol.SelectedValue.ToString());
                //laMarca.tipoMoneda;
                Comando<bool> comandoGenerar = FabricaComandos.CrearAgregarUsuario(elUsuario);
                comandoGenerar.Ejecutar();
            }
            catch (ExceptionCity.ExceptionCcConBD ex)
            {
                vista.alertaClase = RecursoPresentadorUsuario.alertaError;
                vista.alertaRol = RecursoPresentadorUsuario.tipoAlerta;
                vista.alerta = RecursoPresentadorUsuario.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorUsuario.alertaHtmlFinal;
            }
        }

    }
}
