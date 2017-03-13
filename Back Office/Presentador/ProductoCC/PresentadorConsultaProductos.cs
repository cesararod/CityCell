using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos.Producto;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.ProductoCC
{
    public class PresentadorConsultaProductos
    {
        IContratoConsultarProducto vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorConsultaProductos(IContratoConsultarProducto vista)
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
            if (msj == RecursoPresentadorProducto.codigoMod)
            {
                vista.alertaClase = RecursoPresentadorProducto.alertaModificado;
                vista.alertaRol = RecursoPresentadorProducto.tipoAlerta;
                vista.alerta = RecursoPresentadorProducto.alertaHtml + RecursoPresentadorProducto.MsjModificado
                    + RecursoPresentadorProducto.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorProducto.codigoAnular)
            {
                vista.alertaClase = RecursoPresentadorProducto.alertaModificado;
                vista.alertaRol = RecursoPresentadorProducto.tipoAlerta;
                vista.alerta = RecursoPresentadorProducto.alertaHtml + RecursoPresentadorProducto.MsjMAnulado
                    + RecursoPresentadorProducto.alertaHtmlFinal;
            }
            if (msj == RecursoPresentadorProducto.codigoCorreo)
            {
                vista.alertaClase = RecursoPresentadorProducto.alertaModificado;
                vista.alertaRol = RecursoPresentadorProducto.tipoAlerta;
                vista.alerta = RecursoPresentadorProducto.alertaHtml + RecursoPresentadorProducto.MsjCorreo
                    + RecursoPresentadorProducto.alertaHtmlFinal;
            }
        }

        public void CargarMarcas()
        {
            try
            {
                List<Entidad> marcas;
                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarTodosMarca();
                marcas = comando.Ejecutar();
                Dictionary<string, string> options = new Dictionary<string, string>();
                foreach (Entidad LaMarca in marcas)
                {
                    Dominio.Entidades.Marca _laMarca = (Dominio.Entidades.Marca)LaMarca;
                    options.Add(_laMarca.IdMarca.ToString(), _laMarca.Nombre);
                    //vista.marca.Items.Add(((Dominio.Entidades.Marca)LaMarca).Nombre);
                }
                /*vista.marca.DataSource = options;
                vista.marca.DataTextField = RecursoPresentadorProducto.valueCombo;
                vista.marca.DataValueField = RecursoPresentadorProducto.keyCombo;
                vista.marca.DataBind();*/
            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }

        public void CargarCategorias()
        {
            try
            {
                List<Entidad> categorias;
                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarTodosCategoria();
                categorias = comando.Ejecutar();
                Dictionary<string, string> options = new Dictionary<string, string>();


                foreach (Entidad LaCategoria in categorias)
                {
                    Dominio.Entidades.Categoria _laCategoria = (Dominio.Entidades.Categoria)LaCategoria;
                    options.Add(_laCategoria.IdCat.ToString(), _laCategoria.Nombre);
                }
               /* vista.categoria.DataSource = options;
                vista.categoria.DataTextField = RecursoPresentadorProducto.valueCombo;
                vista.categoria.DataValueField = RecursoPresentadorProducto.keyCombo;
                vista.categoria.DataBind();*/
            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }

        public void cargarConsultarMarcas()
        {
            bool activada = false;
            try
            {
                Comando<List<Entidad>> comando = FabricaComandos.CrearConsultarTodosProductos();
                List<Entidad> listaEntidad = comando.Ejecutar();
                //Categoria _laCompania = (Categoria)FabricaEntidades.CrearCompaniaVacia();
                // DominioTangerine.Entidades.M7.Proyecto _elProyecto =
                //(DominioTangerine.Entidades.M7.Proyecto)FabricaEntidades.ObtenerProyecto();

                foreach (Marca laMarca in listaEntidad)
                {

                    vista.productosCreados += RecursoPresentadorProducto.OpenTr;
                    vista.productosCreados += RecursoPresentadorProducto.OpenTD + laMarca.IdMarca.ToString()
                        + RecursoPresentadorProducto.CloseTd;
                    vista.productosCreados += RecursoPresentadorProducto.OpenTD + laMarca.Nombre
                        + RecursoPresentadorProducto.CloseTd;
                    //Equals cero para factura "Por Pagar"
                    if (laMarca.Activo.Equals(0))
                    {
                        vista.productosCreados += RecursoPresentadorProducto.OpenTD + RecursoPresentadorProducto.porActivar
                            + RecursoPresentadorProducto.CloseTd;

                    }
                    //Equals uno para factura "Pagada"
                    else if (laMarca.Activo.Equals(1))
                    {
                        activada = true;
                        vista.productosCreados += RecursoPresentadorProducto.OpenTD + RecursoPresentadorProducto.Activada
                            + RecursoPresentadorProducto.CloseTd;
                    }

                    //Acciones de cada contacto
                    vista.productosCreados += RecursoPresentadorProducto.OpenTD;

                    if (activada == true)
                    {
                        vista.productosCreados +=
                            RecursoPresentadorProducto.BotonModif + laMarca.IdMarca.ToString()
                            + RecursoPresentadorProducto.CloseBotonParametro
                            + RecursoPresentadorProducto.BotonAnular + laMarca.IdMarca.ToString()
                            + RecursoPresentadorProducto.CloseBotonParametro;
                    }
                    else
                    {
                        vista.productosCreados +=
                            RecursoPresentadorProducto.BotonModif + laMarca.IdMarca.ToString()
                            + RecursoPresentadorProducto.CloseBotonParametro
                            + RecursoPresentadorProducto.BotonAnular + laMarca.IdMarca.ToString()
                            + RecursoPresentadorProducto.CloseBotonParametro;
                    }
                    vista.productosCreados += RecursoPresentadorProducto.CloseTd;
                    vista.productosCreados += RecursoPresentadorProducto.CloseTr;
                    activada = false;

                }
            }
            catch (ExceptionsCity ex)
            {
                vista.alertaClase = RecursoPresentadorProducto.alertaError;
                vista.alertaRol = RecursoPresentadorProducto.tipoAlerta;
                vista.alerta = RecursoPresentadorProducto.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorProducto.alertaHtmlFinal;
            }
        }
    }


}
