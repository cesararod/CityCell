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
    public class PresentadorReporte4
    {
        IContratoReporte2 vista;

        /// <summary>
        /// Constructor de la clase, que recibe la vista
        /// </summary>
        /// <param name="vista"></param>
        public PresentadorReporte4(IContratoReporte2 vista)
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
                ElReporte.Estado_Id = int.Parse(vista.Estado.SelectedValue.ToString());

                Comando<List<Entidad>> comando = LogicaCC.Fabrica.FabricaComandos.CrearConsultarReporte4(ElReporte);
                List<Entidad> reporte = comando.Ejecutar();
                vista.TablaReporte2 = null;
                foreach (Usuario ElUsuario in reporte)
                {

                    vista.TablaReporte2 += Recurso.OpenTr;
                    vista.TablaReporte2 += Recurso.OpenTD + ElUsuario.IdUser.ToString()
                        + Recurso.CloseTd;
                    vista.TablaReporte2 += Recurso.OpenTD + ElUsuario.Nombre + Recurso.espacio + ElUsuario.Apellido
                        + Recurso.CloseTd;
                    vista.TablaReporte2 += Recurso.OpenTD + ElUsuario.Cedula
                        + Recurso.CloseTd;
                    vista.TablaReporte2 += Recurso.OpenTD + ElUsuario.Fecha_Ingreso
                        + Recurso.CloseTd;
                    vista.TablaReporte2 += Recurso.OpenTD + ElUsuario.Email
                        + Recurso.CloseTd;
                    vista.TablaReporte2 += Recurso.OpenTD + ElUsuario.Telefono
                        + Recurso.CloseTd;
                    vista.TablaReporte2 += Recurso.OpenTD + ElUsuario.Celular
                        + Recurso.CloseTd;



                    if (ElUsuario.Activo == 1)
                    {
                        vista.TablaReporte2 += Recurso.OpenTD + Recurso.Activo
                        + Recurso.CloseTd;
                    }
                    else
                    {
                        vista.TablaReporte2 += Recurso.OpenTD + Recurso.Inactivo
                        + Recurso.CloseTd;
                    }
                    vista.TablaReporte2 += Recurso.CloseTd;
                    vista.TablaReporte2 += Recurso.CloseTr;

                }

            }
            catch (Exception ex)
            {
                vista.alerta = ex.Message;
            }
        }
    }
}
