using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos;
using Contratos.Marca;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.MarcaCC
{
    public class PresentadorModificarMarca
    {
         IContratoModificarMarca vista;

         public PresentadorModificarMarca(IContratoModificarMarca vista)
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
         public void Modificar()
         {
             try
             {
                 Marca laMarca = (Marca)FabricaEntidades.MarcaVacia();
                 laMarca.IdMarca = int.Parse(vista.id_Marca.ToString());
                 laMarca.Activo = int.Parse(vista.activo.SelectedValue.ToString());
                 //laMarca.tipoMoneda;
                 Comando<bool> comando = FabricaComandos.CrearModificarMarca(laMarca);
                 comando.Ejecutar();
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
