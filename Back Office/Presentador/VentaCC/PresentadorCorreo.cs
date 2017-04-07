using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
    public class PresentadorCorreo
    {
        IContratoCorreo vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorCorreo(IContratoCorreo vista)
        {
            this.vista = vista;
        }

        /// <summary>
        /// Método para manejar los errores y mensajes a interfaz
        /// <param name="msj">Mensaje a mostrar a interfaz</param>
        /// Son respuestas positivas sobre acciones del usuario
        /// </summary>
        public void Alerta(string msj)
        {
            if (msj == RecursoPresentadorVenta.codigoMod)
            {
                vista.alertaClase = RecursoPresentadorVenta.alertaModificado;
                vista.alertaRol = RecursoPresentadorVenta.tipoAlerta;
                vista.alerta = RecursoPresentadorVenta.alertaHtml + RecursoPresentadorVenta.MsjModificado
                    + RecursoPresentadorVenta.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorVenta.codigoAnular)
            {
                vista.alertaClase = RecursoPresentadorVenta.alertaModificado;
                vista.alertaRol = RecursoPresentadorVenta.tipoAlerta;
                vista.alerta = RecursoPresentadorVenta.alertaHtml + RecursoPresentadorVenta.MsjMAnulado
                    + RecursoPresentadorVenta.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorVenta.codigoCorreo)
            {
                vista.alertaClase = RecursoPresentadorVenta.alertaModificado;
                vista.alertaRol = RecursoPresentadorVenta.tipoAlerta;
                vista.alerta = RecursoPresentadorVenta.alertaHtml + RecursoPresentadorVenta.MsjCorreo
                    + RecursoPresentadorVenta.alertaHtmlFinal;
            }
        }

        public bool enviarCorreo()
        {
            try
            {
                Venta ElCorreo = (Venta)FabricaEntidades.VentaVacia();
                                
                ElCorreo.Mail = vista.Mail;
                ElCorreo.Id_Venta = int.Parse(vista.VenId.ToString());
                ElCorreo.Estatus = vista.Status;
                DatosCorreo _datosCorreo =
                            (DatosCorreo)FabricaEntidades.ObtenerDatosCorreo("Verificacion de su pago" 
                            , ElCorreo.Mail,"Estimado Cliente, su pago fue recibido y clasificado como "+ ElCorreo.Estatus
                            + ". Si tiene dudas puede comunicarce a ventas@citycellgsm.com. ", ElCorreo.Id_Venta);

                    /*if (vista.adjunto != String.Empty)
                    {
                        _datosCorreo.adjunto = RecursoPresentadorM8.rutaFacturas + vista.adjunto;
                    }*/

                    Comando<bool> _comandoCorreo = FabricaComandos.CrearEnviarCorreo(_datosCorreo);

                    return _comandoCorreo.Ejecutar();

                    //Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarTodosVentas();
                    //List<Entidad> venta = comando.Ejecutar();
                

            }
            catch (ExceptionsCity ex)
            {
                vista.alertaClase = RecursoPresentadorVenta.alertaError;
                vista.alertaRol = RecursoPresentadorVenta.tipoAlerta;
                vista.alerta = RecursoPresentadorVenta.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorVenta.alertaHtmlFinal;
                return false;
            }
        }
    }
}
