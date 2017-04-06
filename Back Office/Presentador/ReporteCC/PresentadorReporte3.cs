using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Globalization;
using LogicaCC;
using Contratos.Reportes;
using DatosCC;
using Dominio;
using Dominio.Fabrica;
using Dominio.Entidades;
using ExceptionCity;
using LogicaCC.Fabrica;

namespace Presentador.ReporteCC
{
    public class PresentadorReporte3
    {
        IContratoReporte3 vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorReporte3(IContratoReporte3 vista)
        {
            this.vista = vista;
        }

        /// <summary>
        /// Método para manejar los errores y mensajes a interfaz
        /// <param name="msj">Mensaje a mostrar a interfaz</param>
        /// Son respuestas positivas sobre acciones del usuario
        /// </summary>
        public void Alerta(string msj)
        {
            if (msj == Recurso.codigoMod)
            {
                vista.alertaClase = Recurso.alertaModificado;
                vista.alertaRol = Recurso.tipoAlerta;
                vista.alerta = Recurso.alertaHtml + Recurso.MsjModificado
                    + Recurso.alertaHtmlFinal;
            }
            if (msj == Recurso.codigoAnular)
            {
                vista.alertaClase = Recurso.alertaModificado;
                vista.alertaRol = Recurso.tipoAlerta;
                vista.alerta = Recurso.alertaHtml + Recurso.MsjMAnulado
                    + Recurso.alertaHtmlFinal;
            }
            if (msj == Recurso.codigoCorreo)
            {
                vista.alertaClase = Recurso.alertaModificado;
                vista.alertaRol = Recurso.tipoAlerta;
                vista.alerta = Recurso.alertaHtml + Recurso.MsjCorreo
                    + Recurso.alertaHtmlFinal;
            }
        }

        public void CargarReporte()
        {
            try
            {
                Reporte ElReporte = new Reporte();
                ElReporte.Estado_Id = int.Parse(vista.categoria.SelectedValue.ToString());
                ElReporte.Fecha_Fin = DateTime.ParseExact(vista.Fecha_Fin, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                ElReporte.Fecha_Inicio = DateTime.ParseExact(vista.Fecha_Inicio, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarReporte3(ElReporte);
                List<Entidad> reporte = comando.Ejecutar();

                foreach (Reporte _ElReporte in reporte)
                {

                    vista.TablaReporte += Recurso.OpenTr;

                    vista.TablaReporte += Recurso.OpenTD + _ElReporte.Pedido.ToString() + Recurso.CloseTd;
                    vista.TablaReporte += Recurso.OpenTD + _ElReporte.Nombre.ToString() + Recurso.CloseTd;
                    vista.TablaReporte += Recurso.OpenTD + _ElReporte.Producto + Recurso.CloseTd;
                    vista.TablaReporte += Recurso.OpenTD + _ElReporte.Total.ToString() + Recurso.CloseTd;
                    vista.TablaReporte += Recurso.OpenTD + _ElReporte.Estatus.ToString() + Recurso.CloseTd;
                    vista.TablaReporte += Recurso.OpenTD + _ElReporte.Categoria + Recurso.CloseTd;
                    vista.TablaReporte += Recurso.OpenTD + _ElReporte.Fecha + Recurso.CloseTd;
                    vista.TablaReporte += Recurso.CloseTr;
                }

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
                vista.categoria.DataTextField = Recurso.valueCombo;
                vista.categoria.DataValueField = Recurso.keyCombo;
                vista.categoria.DataBind();
            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }
    }
}
