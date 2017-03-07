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
    public class PresentadorAgregarMarca
    {
        IContratoAgregarMarca vista;

        public PresentadorAgregarMarca(IContratoAgregarMarca vista)
        {
            this.vista = vista;
        }

        /// <summary>
        /// Método para manejar los errores y mensajes a interfaz
        /// </summary>
        public void Alerta(string msj)
        {
            vista.alertaClase = RecursoPresentadorMarca.alertaError;
            vista.alertaRol = RecursoPresentadorMarca.tipoAlerta;
            vista.alerta = RecursoPresentadorMarca.alertaHtml + msj + RecursoPresentadorMarca.alertaHtmlFinal;
        }

        /// <summary>
        /// Método para llenar los generar la categoria
        /// </summary>
        public void GenerarMarca()
        {
            try
            {
                Marca laMarca = (Marca)FabricaEntidades.MarcaVacia();
                laMarca.Nombre = vista.nombre;
                laMarca.Activo = int.Parse(vista.activo.SelectedValue.ToString());
                laMarca.Imagen = RecursoPresentadorMarca.ruta + vista.ruta_logo;
                laMarca.Fecha = DateTime.Now; ;
                //laMarca.tipoMoneda;
                Comando<bool> comandoGenerar = FabricaComandos.CrearAgregarMarca(laMarca);
                comandoGenerar.Ejecutar();
            }
            catch (ExceptionCity.ExceptionCcConBD ex)
            {
                vista.alertaClase = RecursoPresentadorMarca.alertaError;
                vista.alertaRol = RecursoPresentadorMarca.tipoAlerta;
                vista.alerta = RecursoPresentadorMarca.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                    + RecursoPresentadorMarca.alertaHtmlFinal;
            }
        }

    }
}
