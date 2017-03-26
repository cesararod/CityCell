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

        public void Generar()
        {
            try
            {
                Garantia laGarantia = (Garantia)FabricaEntidades.GarantiaVacia();
                laGarantia.Marca = int.Parse(vista.marca.ToString());
                laGarantia.Cateoria = int.Parse(vista.cateoria.ToString());
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
