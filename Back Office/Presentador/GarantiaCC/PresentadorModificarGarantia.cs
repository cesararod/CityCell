using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos;
using Contratos.Garantia;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;


namespace Presentador.GarantiaCC
{
    public class PresentadorModificarGarantia
    {
        IContratoModificarGarantia vista;

        public PresentadorModificarGarantia(IContratoModificarGarantia vista)
        {
            this.vista = vista;
        }

         /// <summary>
         /// Método para manejar los errores y mensajes a interfaz
         /// </summary>
         public void Alerta(string msj)
         {
             vista.alertaClase = RecursoPresentadorGarantia.alertaError;
             vista.alertaRol = RecursoPresentadorGarantia.tipoAlerta;
             vista.alerta = RecursoPresentadorGarantia.alertaHtml + msj + RecursoPresentadorGarantia.alertaHtmlFinal;
         }

         /// <summary>
         /// Método para llenar los generar la categoria
         /// </summary>
         public void Modificar()
         {
             try
             {
                 Garantia laGarantia = (Garantia)FabricaEntidades.GarantiaVacia();
                 laGarantia.IdGar = int.Parse(vista.idGar.ToString());
                 laGarantia.Descripcion = vista.descripcion;
                 //laGarantia.tipoMoneda;
                 Comando<bool> comando = FabricaComandos.CrearModificarGarantia(laGarantia);
                 comando.Ejecutar();
             }
             catch (ExceptionCity.ExceptionCcConBD ex)
             {
                 vista.alertaClase = RecursoPresentadorGarantia.alertaError;
                 vista.alertaRol = RecursoPresentadorGarantia.tipoAlerta;
                 vista.alerta = RecursoPresentadorGarantia.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                     + RecursoPresentadorGarantia.alertaHtmlFinal;
             }
         }
    }
}
