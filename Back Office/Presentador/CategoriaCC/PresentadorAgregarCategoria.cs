using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LogicaCC;
using Contratos;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;


namespace Presentador.CategoriaCC
{
    public class PresentadorAgregarCategoria
    {
        IContratoGenerarCategoria vista;

        public PresentadorAgregarCategoria(IContratoGenerarCategoria vista)
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
         public void GenerarCategoria()
         {
             try
             {
                 Categoria laCategoria = (Categoria)FabricaEntidades.CategoriaVacia();
                 laCategoria.Nombre = vista.nombre;
                 laCategoria.Activo = vista.activo;
                 laCategoria.Destacado = vista.destacado;
                 laCategoria.Fecha_Creacion = DateTime.Now;;
                 //laCategoria.tipoMoneda;
                 Comando<bool> comandoGenerar = FabricaComandos.CrearAgregarCategoria(laCategoria);
                 comandoGenerar.Ejecutar();
             }
             {
             }
         }
    }
}
