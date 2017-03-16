using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos;
using Contratos.Categoria;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.CategoriaCC
{
    public class PresentadorModificarCategoria
    {
        IContratoModificarCategoria vista;

        public PresentadorModificarCategoria(IContratoModificarCategoria vista)
        {
            this.vista = vista;
        }

         /// <summary>
         /// Método para manejar los errores y mensajes a interfaz
         /// </summary>
         public void Alerta(string msj)
         {
             vista.alertaClase = RecursoPresentadorCategoria.alertaError;
             vista.alertaRol = RecursoPresentadorCategoria.tipoAlerta;
             vista.alerta = RecursoPresentadorCategoria.alertaHtml + msj + RecursoPresentadorCategoria.alertaHtmlFinal;
         }

         /// <summary>
         /// Método para llenar los generar la categoria
         /// </summary>
         public void ModificarCategoria()
         {
             try
             {
                 Categoria laCategoria = (Categoria)FabricaEntidades.CategoriaVacia();
                 laCategoria.IdCat = int.Parse(vista.id_Categoria.ToString());
                 laCategoria.Activo = int.Parse(vista.activo.SelectedValue.ToString());
                 laCategoria.Destacado = int.Parse(vista.destacado.SelectedValue.ToString());
                 //laCategoria.tipoMoneda;
                 Comando<bool> comando = FabricaComandos.CrearModificarCategoria(laCategoria);
                 comando.Ejecutar();
             }
             catch (ExceptionCity.ExceptionCcConBD ex)
             {
                 vista.alertaClase = RecursoPresentadorCategoria.alertaError;
                 vista.alertaRol = RecursoPresentadorCategoria.tipoAlerta;
                 vista.alerta = RecursoPresentadorCategoria.alertaHtml + ex.Mensaje + ex.Excepcion.InnerException.Message
                     + RecursoPresentadorCategoria.alertaHtmlFinal;
             }
         }

    }
}
