using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos.Garantia;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.GarantiaCC
{
    public class PresentadorConsultaGarantia
    {
        IContratoConsultarGarantia vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorConsultaGarantia(IContratoConsultarGarantia vista)
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
            if (msj == RecursoPresentadorGarantia.codigoMod)
            {
                vista.alertaClase = RecursoPresentadorGarantia.alertaModificado;
                vista.alertaRol = RecursoPresentadorGarantia.tipoAlerta;
                vista.alerta = RecursoPresentadorGarantia.alertaHtml + RecursoPresentadorGarantia.MsjModificado
                    + RecursoPresentadorGarantia.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorGarantia.codigoAnular)
            {
                vista.alertaClase = RecursoPresentadorGarantia.alertaModificado;
                vista.alertaRol = RecursoPresentadorGarantia.tipoAlerta;
                vista.alerta = RecursoPresentadorGarantia.alertaHtml + RecursoPresentadorGarantia.MsjMAnulado
                    + RecursoPresentadorGarantia.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorGarantia.codigoCorreo)
            {
                vista.alertaClase = RecursoPresentadorGarantia.alertaModificado;
                vista.alertaRol = RecursoPresentadorGarantia.tipoAlerta;
                vista.alerta = RecursoPresentadorGarantia.alertaHtml + RecursoPresentadorGarantia.MsjCorreo
                    + RecursoPresentadorGarantia.alertaHtmlFinal;
            }
        }

        /// <summary>
        /// Método para cargar la tabla con las facturas existentes
        /// </summary>
        public void cargarConsultar()
        {
            bool activada = false;
            try
            {
                Comando<List<Entidad>> comando = FabricaComandos.CrearConsultarTodosGarantia();
                List<Entidad> listaEntidad = comando.Ejecutar();
                //Categoria _laCompania = (Categoria)FabricaEntidades.CrearCompaniaVacia();
                // DominioTangerine.Entidades.M7.Proyecto _elProyecto =
                //(DominioTangerine.Entidades.M7.Proyecto)FabricaEntidades.ObtenerProyecto();

                foreach (Garantia laGarantia in listaEntidad)
                {

                    vista.garantiasCreadas += RecursoPresentadorGarantia.OpenTr;
                    vista.garantiasCreadas += RecursoPresentadorGarantia.OpenTD + laGarantia.IdGar.ToString()
                        + RecursoPresentadorGarantia.CloseTd;
                    vista.garantiasCreadas += RecursoPresentadorGarantia.OpenTD + laGarantia.NMarca
                        + RecursoPresentadorGarantia.CloseTd;
                    vista.garantiasCreadas += RecursoPresentadorGarantia.OpenTD + laGarantia.NCategoria
                        + RecursoPresentadorGarantia.CloseTd;
                    //vista.garantiasCreadas += RecursoPresentadorGarantia.OpenTD + laGarantia.Descripcion
                        //+ RecursoPresentadorGarantia.CloseTd;
                    //Acciones de cada contacto
                    vista.garantiasCreadas += RecursoPresentadorGarantia.OpenTD;

                    if (activada == true)
                    {
                        vista.garantiasCreadas +=
                            RecursoPresentadorGarantia.BotonModif + laGarantia.IdGar.ToString()
                            + RecursoPresentadorGarantia.CloseBotonParametro;
                    }
                    else
                    {
                        vista.garantiasCreadas +=
                            RecursoPresentadorGarantia.BotonModif + laGarantia.IdGar.ToString()
                            + RecursoPresentadorGarantia.CloseBotonParametro;
                    }
                    vista.garantiasCreadas += RecursoPresentadorGarantia.CloseTd;
                    vista.garantiasCreadas += RecursoPresentadorGarantia.CloseTr;
                    activada = false;

                }
            }
            catch (ExceptionsCity ex)
            {
                vista.alertaClase = RecursoPresentadorGarantia.alertaError;
                vista.alertaRol = RecursoPresentadorGarantia.tipoAlerta;
                vista.alerta = RecursoPresentadorGarantia.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorGarantia.alertaHtmlFinal;
            }
        }
    }
}
