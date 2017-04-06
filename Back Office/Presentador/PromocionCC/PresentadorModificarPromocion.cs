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
    public class PresentadorModificarPromocion
    {
        IContratoModificarPromocion vista;

        public PresentadorModificarPromocion(IContratoModificarPromocion vista)
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


        /* public void LLenarModificar(string prodnombre,  string prodmodelo, string proddescripcion,  string prodprecio, string cantidad){
            vista.nombre = prodnombre;
            vista.modelo = prodmodelo;
            vista.descripcion = proddescripcion;
            vista.precio = prodprecio;
            vista.cantidad = cantidad;
         }*/

         /// <summary>
         /// Método para modificar los producrtos
         /// </summary>
         public void Modificar()
         {
             try
             {
                 Promocion laPromocion = (Promocion)FabricaEntidades.PromocionVacia();

                 laPromocion.Precio = int.Parse(vista.precio);
                 laPromocion.Id_Promo = int.Parse(vista.id_promocion.ToString());
                 laPromocion.Fecha_Fin = DateTime.ParseExact(vista.Fecha_Fin, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                 laPromocion.Fecha_Inicio = DateTime.ParseExact(vista.Fecha_Inicio, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                 //laPromocion.tipoMoneda;
                 Comando<bool> comando = FabricaComandos.CrearModificarPromocion(laPromocion);
                 comando.Ejecutar();
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
