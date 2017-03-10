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
    public class PresentadorAgregarProducto
    {
        IContratoAgregarProducto vista;

        public PresentadorAgregarProducto(IContratoAgregarProducto vista)
        {
            this.vista = vista;
        }

        /// <summary>
        /// Método para manejar los errores y mensajes a interfaz
        /// </summary>
        public void Alerta(string msj)
        {
            vista.alertaClase = RecursoPresentadorProducto.alertaError;
            vista.alertaRol = RecursoPresentadorProducto.tipoAlerta;
            vista.alerta = RecursoPresentadorProducto.alertaHtml + msj + RecursoPresentadorProducto.alertaHtmlFinal;
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
                vista.marca.DataTextField = RecursoPresentadorProducto.valueCombo;
                vista.marca.DataValueField = RecursoPresentadorProducto.keyCombo;
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
                vista.categoria.DataTextField = RecursoPresentadorProducto.valueCombo;
                vista.categoria.DataValueField = RecursoPresentadorProducto.keyCombo;
                vista.categoria.DataBind();
            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }

        /// <summary>
        /// Método para llenar los generar la categoria
        /// </summary>
        public void GenerarProducto()
        {
            try
            {
                Producto elProducto = (Producto)FabricaEntidades.ProductoVacio();
                elProducto.Nombre = vista.nombre;
                elProducto.Cantidad = int.Parse(vista.cantidad.ToString());
                elProducto.Activo = int.Parse(vista.activo.SelectedValue.ToString());
                elProducto.Fk_Marca = int.Parse(vista.marca.SelectedValue.ToString());
                elProducto.Fk_Categoria = int.Parse(vista.categoria.SelectedValue.ToString());
                elProducto.Modelo = vista.modelo;
                elProducto.Descripcion = vista.descripcion;
                elProducto.Precio = float.Parse(vista.precio.ToString());
                elProducto.Peso = float.Parse(vista.peso.ToString());
                elProducto.Alto = float.Parse(vista.alto.ToString());
                elProducto.Ancho = float.Parse(vista.ancho.ToString());
                elProducto.Largo = float.Parse(vista.largo.ToString());
                elProducto.Fecha_Creacion = DateTime.Now; ;
                //laMarca.tipoMoneda;
                Comando<bool> comandoGenerar = FabricaComandos.CrearAgregarProducto(elProducto);
                comandoGenerar.Ejecutar();
            }
            catch (ExceptionCity.ExceptionCcConBD ex)
            {
                vista.alertaClase = RecursoPresentadorProducto.alertaError;
                vista.alertaRol = RecursoPresentadorProducto.tipoAlerta;
                vista.alerta = RecursoPresentadorProducto.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorProducto.alertaHtmlFinal;
            }
        }
    }
}
