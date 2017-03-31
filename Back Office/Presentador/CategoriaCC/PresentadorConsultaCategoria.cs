using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.CategoriaCC
{
    public class PresentadorConsultaCategoria
    {
        IContratoConsultarCategoria vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorConsultaCategoria(IContratoConsultarCategoria vista)
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
            if (msj == RecursoPresentadorCategoria.codigoMod)
            {
                vista.alertaClase = RecursoPresentadorCategoria.alertaModificado;
                vista.alertaRol = RecursoPresentadorCategoria.tipoAlerta;
                vista.alerta = RecursoPresentadorCategoria.alertaHtml + RecursoPresentadorCategoria.MsjModificado
                    + RecursoPresentadorCategoria.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorCategoria.codigoAnular)
            {
                vista.alertaClase = RecursoPresentadorCategoria.alertaModificado;
                vista.alertaRol = RecursoPresentadorCategoria.tipoAlerta;
                vista.alerta = RecursoPresentadorCategoria.alertaHtml + RecursoPresentadorCategoria.MsjMAnulado
                    + RecursoPresentadorCategoria.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorCategoria.codigoCorreo)
            {
                vista.alertaClase = RecursoPresentadorCategoria.alertaModificado;
                vista.alertaRol = RecursoPresentadorCategoria.tipoAlerta;
                vista.alerta = RecursoPresentadorCategoria.alertaHtml + RecursoPresentadorCategoria.MsjCorreo
                    + RecursoPresentadorCategoria.alertaHtmlFinal;
            }
        }

        /// <summary>
        /// Método para cargar la tabla con las facturas existentes
        /// </summary>
        public void cargarConsultarCategorias()
        {
            bool activada = false;
            try
            {
                Comando<List<Entidad>> comando = FabricaComandos.CrearConsultarTodosCategoria();
                List<Entidad> listaEntidad = comando.Ejecutar();
                //Categoria _laCompania = (Categoria)FabricaEntidades.CrearCompaniaVacia();
               // DominioTangerine.Entidades.M7.Proyecto _elProyecto =
                    //(DominioTangerine.Entidades.M7.Proyecto)FabricaEntidades.ObtenerProyecto();

                foreach (Categoria laCategoria in listaEntidad)
                {
                   
                    vista.categoriasCreadas += RecursoPresentadorCategoria.OpenTr;
                    vista.categoriasCreadas += RecursoPresentadorCategoria.OpenTD + laCategoria.IdCat.ToString()
                        + RecursoPresentadorCategoria.CloseTd;
                    vista.categoriasCreadas += RecursoPresentadorCategoria.OpenTD + laCategoria.Nombre
                        + RecursoPresentadorCategoria.CloseTd;
                    //Equals cero para factura "Por Pagar"
                    if (laCategoria.Activo.Equals(0))
                    {
                        vista.categoriasCreadas += RecursoPresentadorCategoria.OpenTD + RecursoPresentadorCategoria.porActivar
                            + RecursoPresentadorCategoria.CloseTd;

                    }
                    //Equals uno para factura "Pagada"
                    else if (laCategoria.Activo.Equals(1))
                    {
                        activada = true;
                        vista.categoriasCreadas += RecursoPresentadorCategoria.OpenTD + RecursoPresentadorCategoria.Activada
                            + RecursoPresentadorCategoria.CloseTd;
                    }
                    

                   
                    
                   //Acciones de cada contacto
                    vista.categoriasCreadas += RecursoPresentadorCategoria.OpenTD;

                    if (activada == true)
                    {
                        vista.categoriasCreadas +=
                            RecursoPresentadorCategoria.BotonModif + laCategoria.IdCat.ToString()
                            + RecursoPresentadorCategoria.CloseBotonParametro;
                    }
                    else
                    {
                        vista.categoriasCreadas +=
                            RecursoPresentadorCategoria.BotonModif + laCategoria.IdCat.ToString()
                            + RecursoPresentadorCategoria.CloseBotonParametro;
                    }
                    vista.categoriasCreadas += RecursoPresentadorCategoria.CloseTd;
                    vista.categoriasCreadas += RecursoPresentadorCategoria.CloseTr;
                    activada = false;

                }
            }
            catch (ExceptionsCity ex)
            {
                vista.alertaClase = RecursoPresentadorCategoria.alertaError;
                vista.alertaRol = RecursoPresentadorCategoria.tipoAlerta;
                vista.alerta = RecursoPresentadorCategoria.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorCategoria.alertaHtmlFinal;
            }
        }
    }
}
