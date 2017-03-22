using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Globalization;
using LogicaCC;
using Contratos.Venta;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.VentaCC
{
    public class PresentadorModificarVenta
    {
         IContratoModificarVenta vista;

         public PresentadorModificarVenta(IContratoModificarVenta vista)
        {
            this.vista = vista;
        }

         /// <summary>
         /// Método para manejar los errores y mensajes a interfaz
         /// </summary>
         public void Alerta(string msj)
         {
             vista.alertaClase = RecursoPresentadorVenta.alertaError;
             vista.alertaRol = RecursoPresentadorVenta.tipoAlerta;
             vista.alerta = RecursoPresentadorVenta.alertaHtml + msj + RecursoPresentadorVenta.alertaHtmlFinal;
         }

         public void Modificar()
         {
             try
             {
                 Venta laVenta = (Venta)FabricaEntidades.VentaVacia();
                 laVenta.Id_Venta = int.Parse(vista.VentaId.ToString());
                 laVenta.Estatus = vista.Estatus.SelectedValue.ToString();
                 Comando<bool> comando = FabricaComandos.CrearModificarVenta(laVenta);
                 comando.Ejecutar();
             }
             catch (ExceptionCity.ExceptionCcConBD ex)
             {
                 vista.alertaClase = RecursoPresentadorVenta.alertaError;
                 vista.alertaRol = RecursoPresentadorVenta.tipoAlerta;
                 vista.alerta = RecursoPresentadorVenta.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                     + RecursoPresentadorVenta.alertaHtmlFinal;
             }
         }
    }
}
