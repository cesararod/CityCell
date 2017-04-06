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
    public class PresentadorActivarUsuario
    {
        IContratoActivarUsuario vista;

        public PresentadorActivarUsuario(IContratoActivarUsuario vista)
        {
            this.vista = vista;
        }

         

        /* public void LLenarModificar(string prodnombre,  string prodmodelo, string proddescripcion,  string prodprecio, string cantidad){
            vista.nombre = prodnombre;
            vista.modelo = prodmodelo;
            vista.descripcion = proddescripcion;
            vista.precio = prodprecio;
            vista.cantidad = cantidad;
         }*/

         /// <summary>
         /// Método para modificar los producrtos
         /// </summary>
         public void Modificar()
         {
             try
             {
                 Usuario elUsuario = (Usuario)FabricaEntidades.UsuarioVacio();
                 elUsuario.IdUser = int.Parse(vista.UsuId.ToString());
                 elUsuario.Activo = int.Parse(vista.activo.ToString());
                 Comando<bool> comando = FabricaComandos.CrearActivarUsuario(elUsuario);
                 comando.Ejecutar();
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
