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
    public class PresentadorAgregarGarantia
    {
        IContratoAgregarGarantia vista;

        public PresentadorAgregarGarantia(IContratoAgregarGarantia vista)
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
                vista.marca.DataSource = options;
                vista.marca.DataTextField = RecursoPresentadorGarantia.valueCombo;
                vista.marca.DataValueField = RecursoPresentadorGarantia.keyCombo;
                vista.marca.DataBind();
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
                vista.categoria.DataSource = options;
                vista.categoria.DataTextField = RecursoPresentadorGarantia.valueCombo;
                vista.categoria.DataValueField = RecursoPresentadorGarantia.keyCombo;
                vista.categoria.DataBind();
            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }

        public void Generar()
        {
            try
            {
                Garantia laGarantia = (Garantia)FabricaEntidades.GarantiaVacia();
                laGarantia.Marca = int.Parse(vista.marca.SelectedValue.ToString());
                laGarantia.Cateoria = int.Parse(vista.categoria.SelectedValue.ToString());
                laGarantia.Descripcion = vista.descripcion;
                //laGarantia.tipoMoneda;
                Comando<bool> comandoGenerar = FabricaComandos.CrearAgregarGarantia(laGarantia);
                comandoGenerar.Ejecutar();
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
