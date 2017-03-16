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
    public class PresentadorModificarProducto
    {
        IContratoModificarProducto vista;

        public PresentadorModificarProducto(IContratoModificarProducto vista)
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

         /// <summary>
         /// Método para modificar los producrtos
         /// </summary>
         public void Modificar()
         {
             try
             {
                 Producto elProducto = (Producto)FabricaEntidades.ProductoVacio();
                 elProducto.IdProducto = int.Parse(vista.id_Producto.ToString());
                 elProducto.Activo = int.Parse(vista.activo.SelectedValue.ToString());
                 elProducto.Cantidad = int.Parse(vista.cantidad.ToString());
                 elProducto.Precio = float.Parse(vista.precio.ToString());
                 elProducto.Nombre = vista.nombre;
                 elProducto.Modelo = vista.modelo;
                 elProducto.Descripcion =vista.descripcion;
                 //elProducto.tipoMoneda;
                 Comando<bool> comando = FabricaComandos.CrearModificarProducto(elProducto);
                 comando.Ejecutar();
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
