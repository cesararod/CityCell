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
    public class PresentadorConsultaVenta
    {
        IContratoConsultarVenta vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorConsultaVenta(IContratoConsultarVenta vista)
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

        public void CargarConsultar()
        {
            bool activada = false;
            try
            {
                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarTodosVentas();
                List<Entidad> venta = comando.Ejecutar();

                foreach (Venta LaVenta in venta)
                {

                    vista.ventasCreados += RecursoPresentadorVenta.OpenTr;
                    vista.ventasCreados += RecursoPresentadorVenta.OpenTD + LaVenta.Id_Venta.ToString()
                        + RecursoPresentadorVenta.CloseTd;
                    vista.ventasCreados += RecursoPresentadorVenta.OpenTD + LaVenta.Nombre + RecursoPresentadorVenta.espacio + LaVenta.Apellido
                        + RecursoPresentadorVenta.CloseTd;
                    vista.ventasCreados += RecursoPresentadorVenta.OpenTD + LaVenta.Pedido
                        + RecursoPresentadorVenta.CloseTd;
                    vista.ventasCreados += RecursoPresentadorVenta.OpenTD + LaVenta.Marca + RecursoPresentadorVenta.espacio + LaVenta.Producto + RecursoPresentadorVenta.espacio + LaVenta.Modelo
                        + RecursoPresentadorVenta.CloseTd;
                    vista.ventasCreados += RecursoPresentadorVenta.OpenTD + LaVenta.Subtotal
                        + RecursoPresentadorVenta.CloseTd;
                    vista.ventasCreados += RecursoPresentadorVenta.OpenTD + LaVenta.Estatus
                        + RecursoPresentadorVenta.CloseTd;

                    //Equals cero para factura "Por Pagar"
                    /* if (LaVenta.Activo.Equals(0))
                     {
                         vista.ventasCreados += RecursoPresentadorVenta.OpenTD + RecursoPresentadorVenta.porActivar
                             + RecursoPresentadorVenta.CloseTd;

                     }
                     //Equals uno para factura "Pagada"
                     else if (LaVenta.Activo.Equals(1))
                     {
                         activada = true;
                         vista.ventasCreados += RecursoPresentadorVenta.OpenTD + RecursoPresentadorVenta.Activada
                             + RecursoPresentadorVenta.CloseTd;
                     }*/

                    //Acciones de cada contacto
                    vista.ventasCreados += RecursoPresentadorVenta.OpenTD;

                    if (activada == true)
                    {
                        vista.ventasCreados +=
                            RecursoPresentadorVenta.BotonModif + LaVenta.Id_Venta.ToString() + RecursoPresentadorVenta.usuario +
                            LaVenta.Nombre + RecursoPresentadorVenta.espacio + LaVenta.Apellido + RecursoPresentadorVenta.producto + LaVenta.Marca + RecursoPresentadorVenta.espacio + LaVenta.Producto + RecursoPresentadorVenta.espacio + LaVenta.Modelo 
                            + RecursoPresentadorVenta.CloseBotonParametro;
                    }
                    else
                    {
                        vista.ventasCreados +=
                            RecursoPresentadorVenta.BotonModif + LaVenta.Id_Venta.ToString() + RecursoPresentadorVenta.usuario +
                            LaVenta.Nombre + RecursoPresentadorVenta.espacio + LaVenta.Apellido + RecursoPresentadorVenta.producto + LaVenta.Marca + RecursoPresentadorVenta.espacio + LaVenta.Producto + RecursoPresentadorVenta.espacio + LaVenta.Modelo
                            + RecursoPresentadorVenta.CloseBotonParametro;
                    }
                    vista.ventasCreados += RecursoPresentadorVenta.CloseTd;
                    vista.ventasCreados += RecursoPresentadorVenta.CloseTr;
                    activada = false;

                }

            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }
    }
}
