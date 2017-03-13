using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Globalization;
using LogicaCC;
using Contratos.Promocion;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.PromocionCC
{
    public class PresentadorAgregarPromocion
    {
        IContratoAgregarPromocion vista;

        public PresentadorAgregarPromocion(IContratoAgregarPromocion vista)
        {
            this.vista = vista;
        }

        /// <summary>
        /// Método para manejar los errores y mensajes a interfaz
        /// </summary>
        public void Alerta(string msj)
        {
            vista.alertaClase = RecursoPresentadorPromocion.alertaError;
            vista.alertaRol = RecursoPresentadorPromocion.tipoAlerta;
            vista.alerta = RecursoPresentadorPromocion.alertaHtml + msj + RecursoPresentadorPromocion.alertaHtmlFinal;
        }

        public void CargarProductos()
        {
            try
            {
                List<Entidad> productos;
                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarTodosProductos();
                productos = comando.Ejecutar();
                Dictionary<string, string> options = new Dictionary<string, string>();
                foreach (Entidad ElProducto in productos)
                {
                    Dominio.Entidades.Producto _ElProducto = (Dominio.Entidades.Producto)ElProducto;
                    options.Add(_ElProducto.IdProducto.ToString(), _ElProducto.Nombre + RecursoPresentadorPromocion.espacio + _ElProducto.Modelo);
                }
                vista.producto.DataSource = options;
                vista.producto.DataTextField = RecursoPresentadorPromocion.valueCombo;
                vista.producto.DataValueField = RecursoPresentadorPromocion.keyCombo;
                vista.producto.DataBind();
            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }

        /// <summary>
        /// Método para llenar los generar la categoria
        /// </summary>
        public void GenerarPromocion()
        {
            try
            {
                Promocion laPromocion = (Promocion)FabricaEntidades.PromocionVacia();
                laPromocion.Precio = int.Parse(vista.precio);
                laPromocion.Activo = int.Parse(vista.activo.SelectedValue.ToString());
                laPromocion.Fk_Producto = int.Parse(vista.producto.SelectedValue.ToString());
                laPromocion.Fecha_Fin = DateTime.ParseExact(vista.Fecha_Fin, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                laPromocion.Fecha_Inicio = DateTime.ParseExact(vista.Fecha_Inicio, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                Comando<bool> comandoGenerar = FabricaComandos.CrearAgregarPromocion(laPromocion);
                comandoGenerar.Ejecutar();
            }
            catch (ExceptionCity.ExceptionCcConBD ex)
            {
                vista.alertaClase = RecursoPresentadorPromocion.alertaError;
                vista.alertaRol = RecursoPresentadorPromocion.tipoAlerta;
                vista.alerta = RecursoPresentadorPromocion.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorPromocion.alertaHtmlFinal;
            }
        }
    }
}
