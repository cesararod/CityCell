using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos.Marca;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.MarcaCC
{
    public class PresentadorConsultaMarca
    {
        IContratoConsultarMarca vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorConsultaMarca(IContratoConsultarMarca vista)
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
            if (msj == RecursoPresentadorMarca.codigoMod)
            {
                vista.alertaClase = RecursoPresentadorMarca.alertaModificado;
                vista.alertaRol = RecursoPresentadorMarca.tipoAlerta;
                vista.alerta = RecursoPresentadorMarca.alertaHtml + RecursoPresentadorMarca.MsjModificado
                    + RecursoPresentadorMarca.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorMarca.codigoAnular)
            {
                vista.alertaClase = RecursoPresentadorMarca.alertaModificado;
                vista.alertaRol = RecursoPresentadorMarca.tipoAlerta;
                vista.alerta = RecursoPresentadorMarca.alertaHtml + RecursoPresentadorMarca.MsjMAnulado
                    + RecursoPresentadorMarca.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorMarca.codigoCorreo)
            {
                vista.alertaClase = RecursoPresentadorMarca.alertaModificado;
                vista.alertaRol = RecursoPresentadorMarca.tipoAlerta;
                vista.alerta = RecursoPresentadorMarca.alertaHtml + RecursoPresentadorMarca.MsjCorreo
                    + RecursoPresentadorMarca.alertaHtmlFinal;
            }
        }

        /// <summary>
        /// Método para cargar la tabla con las facturas existentes
        /// </summary>
        public void cargarConsultarMarcas()
        {
            bool activada = false;
            try
            {
                Comando<List<Entidad>> comando = FabricaComandos.CrearConsultarTodosMarca();
                List<Entidad> listaEntidad = comando.Ejecutar();
                //Categoria _laCompania = (Categoria)FabricaEntidades.CrearCompaniaVacia();
                // DominioTangerine.Entidades.M7.Proyecto _elProyecto =
                //(DominioTangerine.Entidades.M7.Proyecto)FabricaEntidades.ObtenerProyecto();

                foreach (Marca laMarca in listaEntidad)
                {

                    vista.marcasCreadas += RecursoPresentadorMarca.OpenTr;
                    vista.marcasCreadas += RecursoPresentadorMarca.OpenTD + laMarca.IdMarca.ToString()
                        + RecursoPresentadorMarca.CloseTd;
                    vista.marcasCreadas += RecursoPresentadorMarca.OpenTD + laMarca.Nombre
                        + RecursoPresentadorMarca.CloseTd;
                    //Equals cero para factura "Por Pagar"
                    if (laMarca.Activo.Equals(0))
                    {
                        vista.marcasCreadas += RecursoPresentadorMarca.OpenTD + RecursoPresentadorMarca.porActivar
                            + RecursoPresentadorMarca.CloseTd;

                    }
                    //Equals uno para factura "Pagada"
                    else if (laMarca.Activo.Equals(1))
                    {
                        activada = true;
                        vista.marcasCreadas += RecursoPresentadorMarca.OpenTD + RecursoPresentadorMarca.Activada
                            + RecursoPresentadorMarca.CloseTd;
                    }
                   
                    //Acciones de cada contacto
                    vista.marcasCreadas += RecursoPresentadorMarca.OpenTD;

                    if (activada == true)
                    {
                        vista.marcasCreadas +=
                            RecursoPresentadorMarca.BotonModif + laMarca.IdMarca.ToString()
                            + RecursoPresentadorMarca.CloseBotonParametro
                            + RecursoPresentadorMarca.BotonAnular + laMarca.IdMarca.ToString()
                            + RecursoPresentadorMarca.CloseBotonParametro;
                    }
                    else
                    {
                        vista.marcasCreadas +=
                            RecursoPresentadorMarca.BotonModif + laMarca.IdMarca.ToString()
                            + RecursoPresentadorMarca.CloseBotonParametro
                            + RecursoPresentadorMarca.BotonAnular + laMarca.IdMarca.ToString()
                            + RecursoPresentadorMarca.CloseBotonParametro;
                    }
                    vista.marcasCreadas += RecursoPresentadorMarca.CloseTd;
                    vista.marcasCreadas += RecursoPresentadorMarca.CloseTr;
                    activada = false;

                }
            }
            catch (ExceptionsCity ex)
            {
                vista.alertaClase = RecursoPresentadorMarca.alertaError;
                vista.alertaRol = RecursoPresentadorMarca.tipoAlerta;
                vista.alerta = RecursoPresentadorMarca.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorMarca.alertaHtmlFinal;
            }
        }
    }
}
